using UnityEngine;
using UnityEngine.Tilemaps;

public class Box : MonoBehaviour
{
    public Tilemap walls;
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
        //RaycastHit2D check = Physics2D.Raycast((Vector2)transform.position+inputValue, inputValue, 1f, obstruction);
        Vector3Int gridPosition = walls.WorldToCell(transform.position + (Vector3)inputValue);
        return !walls.HasTile(gridPosition);
    }
}
