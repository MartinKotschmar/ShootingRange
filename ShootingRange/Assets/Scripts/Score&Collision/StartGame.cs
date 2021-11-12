using System.Collections;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Canvas CountdownCanvas;
    public TMPro.TextMeshProUGUI countDownText;
    public TimerController TimerController;

    private bool countdownFinished = false;

    public void DoStartGame()
    {
        CountdownCanvas.gameObject.SetActive(true);
        System.Threading.Thread.Sleep(500);

        StartCoroutine(Countdown());
    }


    IEnumerator Countdown()
    {
        for (int i = 3; i >= 1; i--)
        {
            countDownText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        //reset lastScoreCount
        KeepScore.Score = 0;
        //hide countdown canvas
        CountdownCanvas.gameObject.SetActive(false);
        //start game timer
        TimerController.BeginTimer();
    }
}
