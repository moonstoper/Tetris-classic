using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetTet : MonoBehaviour
{
    public GameObject[] Tetblock = new GameObject[7];
    public Vector3[] rotat = new Vector3[7];
    public GameObject getdwn;
   // public GameObject[] GhostB = new GameObject[7];
    //Transform gridT[]
    public GameObject todes;
    // Start is called before the first frame update
    public int num;
    void Start()
    {  int x = Random.Range(0, 6);
        num = x;
        GameObject newT=Instantiate(Tetblock[x], transform.position, Quaternion.identity);
        newT.AddComponent<TetriBlock>();
        newT.GetComponent<TetriBlock>().rotationpoint = rotat[num];
        //GameObject ghostNew = Instantiate(todes, transform.position, Quaternion.identity);
        //ghostNew.AddComponent<TetriBlock>().ghost = ghostNew;
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
           // GameObject ghostNew=Instantiate(GhostB[num], transform.position, Quaternion.identity);
           // ghostNew.AddComponent<Pre_Pos>().Org = newT;
            
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
