using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandom : MonoBehaviour
{
    public GameObject[] NextBlock= new GameObject[7];
    public GameObject created;
    public int rn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    
    public void GetBlock()
    {   
        rn=Random.Range(0,6);
        created= Instantiate(NextBlock[rn], transform.position, Quaternion.identity);
        created.GetComponent<TetriBlock>().enabled = false;
        //return rn;
    }
     public int GetRnum()
    {
        Destroy(FindObjectOfType<GetRandom>().created);
        return rn;
    }

}
