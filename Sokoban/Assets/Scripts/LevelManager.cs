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
            case "Level1": nextLevel = "Level2"; break;
            case "Level2": nextLevel = "Level3"; break;
            case "Level3": nextLevel = "End"; break;
            default: nextLevel = "Level1"; break;
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
