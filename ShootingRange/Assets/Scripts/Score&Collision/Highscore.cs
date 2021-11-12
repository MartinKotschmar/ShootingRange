using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public List<int> highscoresList;
    public GameObject highscoresListItemTemplate;
    private GameObject parentOfHighscoresList;

    private void Awake()
    {
        parentOfHighscoresList = GameObject.Find("Content - HighscoreList");
    }

    public void AddToHighscoresList(int newScore)
    {
        highscoresList.Add(newScore);
    }

    public void RemoveOldListItems()
    {
        foreach (Transform child in parentOfHighscoresList.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void RenderHighscoreList()
    {
        GameObject highscoreListItemTemplate = highscoresListItemTemplate;
        GameObject g;
        for (int i = 0; i < highscoresList.Count; i++)
        {
            g = Instantiate(highscoreListItemTemplate, parentOfHighscoresList.transform);
            g.transform.GetComponent<TMPro.TextMeshProUGUI>().text = highscoresList[i].ToString();
        }
    }

    public void SortHighscoresList()
    {
        highscoresList.Sort((a, b) => b.CompareTo(a));
    }
}