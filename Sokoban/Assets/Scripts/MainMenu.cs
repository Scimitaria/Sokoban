using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame()
    {
        if (Application.isEditor) UnityEditor.EditorApplication.isPlaying = false;return;
        Application.Quit();
    }
}
