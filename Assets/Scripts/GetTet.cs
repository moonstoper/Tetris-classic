using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetTet : MonoBehaviour
{
    public GameObject[] Tetblock = new GameObject[7];
    public Vector3[] rotat = new Vector3[7];
    //Transform gridT[]
    //public GameObject todes;
    // Start is called before the first frame update
    public int num;
    void Start()
    {
        GameObject newT=Instantiate(Tetblock[Random.Range(0, 6)], transform.position, Quaternion.identity);
        newT.AddComponent<TetriBlock>();
        GameObject.Find("NextTile").GetComponent<GetRandom>().GetBlock();
        
    }

    // Update is called once per frame
    public void spawnblock()
    {   
         num= FindObjectOfType<GetRandom>().GetRnum();
        if (Hastop())
        {
            FindObjectOfType<GameOver>().Gameovr();

        }
        else
        {
            GameObject newT = Instantiate(Tetblock[num], transform.position, Quaternion.identity);
            newT.AddComponent<TetriBlock>();
            newT.GetComponent<TetriBlock>().rotationpoint = rotat[num];
            FindObjectOfType<GetRandom>().GetBlock();

            // Destroy(FindObjectOfType<GetRandom>().created);
        }


    }

    bool Hastop()
    {
        if (FindObjectOfType<TetriBlock>().HasTop()==true)
        {
            return true;
        }

        return false;
    }
}
