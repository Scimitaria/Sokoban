using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class Box : MonoBehaviour
{
    public Tilemap walls;
    public LayerMask obstruction;
    public bool atGoal;
    void Start()
    {
        atGoal = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.name == "Goal" && gameObject.name == "Bob")||(collision.name == "Goal (1)" && gameObject.name == "Bob (1)")) atGoal = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.name == "Goal" && gameObject.name == "Bob")||(collision.name == "Goal (1)" && gameObject.name == "Bob (1)")) atGoal = false;
    }

    public bool CanMove(Vector2 inputValue)
    {
        //RaycastHit2D check = Physics2D.Raycast((Vector2)transform.position+inputValue, inputValue, 1f, obstruction);
        Vector3Int gridPosition = walls.WorldToCell(transform.position + (Vector3)inputValue);
        return !walls.HasTile(gridPosition);
    }
}
