using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject[] boxes;
    public float step;
    public LayerMask obstruction;
    Vector2 target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = (Vector2)transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, step * Time.deltaTime);
    }

    void OnMove(InputValue value)
    { 
        Vector2 inputValue = value.Get<Vector2>();
        RaycastHit2D check = Physics2D.Raycast(transform.position, inputValue, 1f, obstruction);
        bool colliderCheck = check.collider == null || (check.collider.gameObject.name.Contains("Bob")&&check.collider.gameObject.GetComponent<Box>().CanMove(inputValue));
        if (inputValue != Vector2.zero && (Vector2)transform.position == target && colliderCheck) target = (!(inputValue.x != 0 && inputValue.y != 0)) ? (Vector2)transform.position + inputValue : (Vector2)transform.position;
    }
}
