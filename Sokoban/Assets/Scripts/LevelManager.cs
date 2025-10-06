using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private string nextLevel;
    public Box[] boxes;
    void Start()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Level 1": nextLevel = "Level 2"; break;
            case "Level 2": nextLevel = "Level 3"; break;
            case "Level 3": nextLevel = "End"; break;
            default: nextLevel = "Level 1"; break;
        }
    }

    void Update()
    {
        if (boxes.All(box => box.atGoal)) SceneManager.LoadScene(nextLevel);
    }

    void OnReload(InputValue value)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
