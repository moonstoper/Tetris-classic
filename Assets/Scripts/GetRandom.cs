using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandom : MonoBehaviour
{
    public GameObject[] NextBlock1= new GameObject[7];
   // [SerializeField] GameObject[] NextBlock2 = new GameObject[7];
    public GameObject created;
    public int rn, rn2;
    int last_num = 0;
    public int[] numbers = new int[7];
    public int total = 7;
    int ins;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    
    public void GetBlock()
    {  
        //from here
        if(total<=0)
        { 
           for(int m=0;m<total;m++)
            {
                numbers[m] = m;
                //num += 1;
                Debug.Log(m);
            }
            total = 7;
           
        }
        rn=Random.Range(0,total-1);
        ins = numbers[rn]; 
        //delete and shift;
        for (int a=0;a<total;a++)
        {
           if(numbers[a]==ins)
            {
                for (int z = a; a < total-1; a++)
                    numbers[z] = numbers[z + 1];
            }
        }

        total -= 1;


        //to here



      
        //rn2 = Random.Range(0, 1);
        //if (rn2 == 0)
            created = Instantiate(NextBlock1[ins], transform.position, Quaternion.identity);
        //else
        //    created = Instantiate(NextBlock1[Mathf.Abs(rn-6)], transform.position, Quaternion.identity);

        // created.GetComponent<TetriBlock>().enabled = false;
        //return rn;

    
    }
     public int GetRnum()
    {
        Destroy(FindObjectOfType<GetRandom>().created);
        //if (rn2 == 0)
        return ins;
        //else
        //    return Mathf.Abs(rn - 6);.
    }

}
