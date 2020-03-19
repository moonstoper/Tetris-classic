using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pre_Pos : MonoBehaviour
{
    public GameObject Org;
    Vector2 xpoint;
    // float rotz;
    public GameObject flx;

    void Start()
    {

        
        
        

    }

    
    void Update()
    {

        int[,] pos = new int[4, 2];
        int a = 0, b = 0;
        Org = GetComponent<TetriBlock>().gameObject;
        Transform babes = Org.transform;
        Debug.LogError(GetComponent<TetriBlock>().gameObject);
        foreach (Transform child in babes)
        {
            int roundedx = Mathf.RoundToInt(child.transform.position.x);
            int roundedy = Mathf.RoundToInt(child.transform.position.y);
            pos[a, b] = roundedx;
            pos[a, b + 1] = roundedy;
            a += 1;
            b = 0;
        }

        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                Debug.Log(pos[x, y]);
            }
        }
        for (int x = 0; x < 3; x++)
        {
            for (int y = 1; y < 4; y++)
            {

                if ((pos[x, 1] - pos[y, 1] >= 0))
                {
                    xpoint.x = pos[x, 0];
                    xpoint.y = pos[x, 1] + .7f;
                    var f = Instantiate(flx, xpoint, Quaternion.identity);
                    Destroy(f, 1f);
                }

            }
        }




    }





    public void DestroUrself()
    {
       

    }



  

}
