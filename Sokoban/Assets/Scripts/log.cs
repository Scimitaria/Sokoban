using TMPro;
using UnityEngine;

public class log : MonoBehaviour
{
    public Player player;
    public TMP_Text logText;

    // Update is called once per frame
    void Update()
    {
        logText.SetText((gameObject.name == "cur") ? ((Vector2)player.transform.position).ToString() : player.target.ToString());
    }
}
