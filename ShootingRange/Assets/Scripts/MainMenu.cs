using UnityEngine;
using UnityEngine.SceneManagement;


/*
 before using, you need to drag all scenes to the "Scenes in Build" part of the "Build Settings"
the MainMenu-Scene needs to be dragged in first, then comes the Game-Scene

to assign the scripts e.g.:
    go to PlayButton->onClick->"+"-> drag Main Menu in there  -> Select Function

source/tutorial: https://www.youtube.com/watch?v=zc8ac_qUXQY
 */
public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
