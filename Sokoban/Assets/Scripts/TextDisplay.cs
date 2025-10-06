using TMPro;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    void Start()
    {
        scoreText = GameObject.Find("Display").GetComponent<TMP_Text>();
        Score score = GameObject.Find("Score").GetComponent<Score>();
        int moves = (score != null) ? score.movesMade : 5999;
        scoreText.SetText((8000 - (moves * 10)).ToString());
    }
}
