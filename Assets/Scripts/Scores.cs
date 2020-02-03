using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scores : MonoBehaviour
{
    public TextMeshPro hscore;
    public TextMeshPro score;
    int multiplier;
    int instant = 0;

    // Start is called before the first frame update
    void Start()
    {
        hscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        multiplier = 1;
        score.text = instant.ToString();
    }

    // Update is called once per frame
    public void Scoring()
    {
        instant += multiplier * 10;
        multiplier += 10;
    }
}
