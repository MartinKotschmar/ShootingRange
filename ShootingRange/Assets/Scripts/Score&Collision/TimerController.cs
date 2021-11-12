using System;
using System.Collections;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI lastScoreTextValue;
    public GameObject player;
    public GameObject highscoreList;

    public static TimerController instance;

    public TMPro.TextMeshProUGUI timeCounter;
    public float timeSpanInSeconds = 30;

    private TimeSpan timePlaying;
    private TimeSpan timeLeftPlaying;
    private bool timerGoing;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeCounter.text = "00:00.00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            if (timeSpanInSeconds <= elapsedTime)
            {
                Cleanup();
                EndTimer();
                yield return null;
            }
            elapsedTime += Time.deltaTime;
            //timePlaying = TimeSpan.FromSeconds(elapsedTime);
            timeLeftPlaying = TimeSpan.FromSeconds(timeSpanInSeconds - elapsedTime);
            string timeLeftPlayingStr = timeLeftPlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timeLeftPlayingStr;
            yield return null;
        }
    }

    private void Cleanup()
    {
        //update last score in mainMenu
        KeepScore lastScore = new KeepScore();
        lastScore.text = lastScoreTextValue;
        lastScore.UpdateLastScore();

        //teleport player back to spawn
        TPBack TPBackInstance = new TPBack();
        TPBackInstance.player = player;
        TPBackInstance.TeleportPlayerBack();

        //update highscoreList
        Highscore highscore = new Highscore();
        highscore.RemoveOldListItems();
        highscore.AddToHighscoresList(KeepScore.Score);
        highscore.SortHighscoresList();
        highscore.RenderHighscoreList();
    }
}
