using UnityEngine;

public class Score : MonoBehaviour
{
    public int movesMade,score=0;
    public Player player;
    void Awake()
    {
        score += 2000;//decrement by x every move player makes - how?
        DontDestroyOnLoad(gameObject);
    }

    public void move()
    {
        movesMade++;
    }
}
