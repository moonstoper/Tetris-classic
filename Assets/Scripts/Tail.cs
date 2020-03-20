using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 xpoint;
    [SerializeField] GameObject flx;
    protected GameObject x;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    public void from_valid(GameObject org,float desTime)
    {
        x = org;
        int[,] pos = new int[4, 2];
        int a = 0, b = 0;
        foreach (Transform child in org.transform)
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

        int[,] newp = new int[4, 2];
       
        for (int x = 0; x < 4; x++)
        {
            int n = 0;
            for (int y = 0; y < 4; y++)
            {
                
                if ((pos[x, 1] - pos[y, 1] >= 0))
                {
                    

                    n++;


                }
                
            }

            if (n >=2)
            {
                xpoint.x = pos[x, 0];
                xpoint.y = pos[x, 1] + 1f;
                var f = Instantiate(flx, xpoint, Quaternion.identity);
                Destroy(f,desTime);


            }
            
        }

    }
}
