using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public List<int> highscoresList;

    public void AddToHighscoresList(int newScore)
    {
        highscoresList.Add(newScore);
    }

    public void RenderHighscoreList()
    {
        GameObject highscoreListItemTemplate = transform.GetChild(0).gameObject;
        GameObject g;
        for (int i = 0; i < highscoresList.Count; i++)
        {
            g = Instantiate(highscoreListItemTemplate, transform);
            g.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = highscoresList[i].ToString();
        }
        Destroy(highscoreListItemTemplate);
    }

    public void SortHighscoresList()
    {
        highscoresList.Sort((a, b) => b.CompareTo(a));
    }
}

//todo template (see youtube)