using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scores : MonoBehaviour
{
    public TextMeshProUGUI hscore;
    public TextMeshProUGUI score;
    int multiplier;
    int instant,high= 0;
   

    // Start is called before the first frame update
    void Start()
    {
        hscore.text = PlayerPrefs.GetInt("HighScores", 0).ToString();
        multiplier = 1;
        score.text = instant.ToString();
        high = int.Parse(hscore.text);

    }

    // Update is called once per frame
    public void Scoring()
    {
        instant += multiplier * 10;
        multiplier += 10;
        score.text = instant.ToString();
        if(high<instant)
        {
            PlayerPrefs.SetInt("HighScores", instant);
            hscore.text = instant.ToString();
            high = instant;
        }
        return;
    }
}
