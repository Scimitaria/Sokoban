using UnityEngine;
using UnityEngine.InputSystem;

public class Box : MonoBehaviour
{
    public LayerMask obstruction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public bool CanMove(Vector2 inputValue)
    {
        RaycastHit2D check = Physics2D.Raycast((Vector2)transform.position+inputValue, inputValue, 1f, obstruction);
        return check.collider == null;
    }
}
