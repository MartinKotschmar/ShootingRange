using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Score = 0;
    public TMPro.TextMeshProUGUI text;

    public void UpdateLastScore()
    {
        text.text = Score.ToString();
    }
}
