using System.Collections.Generic;
using UnityEngine;

public class SaveHighscoreData : MonoBehaviour
{
    public List<int> savedHighscoresList = new List<int>();

    public void saveData(int newHighscore)
    {
        savedHighscoresList.Add(newHighscore);
        SortHighscoresList();
    }

    private void SortHighscoresList()
    {
        savedHighscoresList.Sort((a, b) => b.CompareTo(a));
    }
}
