using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ScoreBoard;
    public GameObject MovementButton;
    public GameObject Gameover;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public  void Gameovr()
    {   

        ScoreBoard.SetActive(false);
        MovementButton.SetActive(false);
        Gameover.SetActive(true);

        Time.timeScale = 0f;


    }
}
