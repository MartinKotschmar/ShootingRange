using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Highscore : MonoBehaviour
{
    public List<int> highscoresList = new List<int>();
    public GameObject highscoresListItemTemplate;
    private GameObject parentOfHighscoresList;

    public void FindHighscoreList()
    {
        parentOfHighscoresList = GameObject.FindGameObjectWithTag("HighscoreList");
    }

    public void AddToHighscoresList(int newScore)
    {
        highscoresList.Add(newScore);
    }

    public void RemoveOldListItems()
    {
        Debug.Log(parentOfHighscoresList);

        if (parentOfHighscoresList.transform.childCount > 0)
        {
            foreach (Transform child in parentOfHighscoresList.transform)
            {
                Destroy(child.gameObject);
            }
        }

    }

    public void RenderHighscoreList()
    {
        GameObject highscoreListItemTemplate = highscoresListItemTemplate;
        GameObject g;
        for (int i = 0; i < highscoresList.Count; i++)
        {
            g = Instantiate(highscoreListItemTemplate, parentOfHighscoresList.transform);

            Debug.Log(highscoresList[i]);

            if (g.transform.GetChild(0).tag == "HighscoreListItem_template")
            {
                TextMeshProUGUI mesh = g.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

                mesh.text = highscoresList[i].ToString();

                Debug.Log(g);
                Debug.Log(g.transform.childCount);
                Debug.Log(mesh);
            }







            // g.transform.GetComponent<TMPro.TextMeshProUGUI>().text = highscoresList[i].ToString();
            //Debug.Log(g.transform.GetComponent<TMPro.TextMeshProUGUI>().text);

        }
    }

    public void SortHighscoresList()
    {
        highscoresList.Sort((a, b) => b.CompareTo(a));
    }
}