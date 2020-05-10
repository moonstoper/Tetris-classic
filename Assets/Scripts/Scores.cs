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
    bool check = false;
    //LeanTween
   

    // Start is called before the first frame update
    private  void Start()
    {
        hscore.text = PlayerPrefs.GetInt("HighScores", 0).ToString();
        multiplier = 1;
        score.text = instant.ToString();
        high = int.Parse(hscore.text);

    }

    // Update is called once per frame
    public void Scoring(int bonus)
    {
        //instant = Mathf.RoundToInt(Mathf.Pow(bonus, bonus)) * 100+instant;
        ////multiplier += 10;
        //score.text = instant.ToString();
        //if(high<instant)
        //{
    
        //    hscore.text = instant.ToString();
        //    high = instant;
        //}
        //PlayerPrefs.SetInt("HighScores",high);
        //Time.timeScale = Time.timeScale + .008f;
        
        return;
    }
}
