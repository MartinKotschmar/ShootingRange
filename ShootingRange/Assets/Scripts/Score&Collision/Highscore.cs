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

            if (g.transform.GetChild(0).tag == "HighscoreListItem_template")
            {
                TextMeshProUGUI mesh = g.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                mesh.text = highscoresList[i].ToString();
            }

        }
    }


}