using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Score = 0;
    public TMPro.TextMeshProUGUI text;
    private void Update()
    {
        text.text = Score.ToString();
    }

    /*
    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100), Score.ToString());
    }
    */
}
