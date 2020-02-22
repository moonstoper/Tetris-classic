using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G1control : MonoBehaviour
{
    Material mat;
    float valy;
    float valx;
    bool vx = true;
    bool vy = true;

    private void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
        valy=mat.GetFloat("_GlitchSy");
        valx= mat.GetFloat("_GlitchSx");
    }
    void FixedUpdate()
    {
        if(vy)
        {   

            mat.SetFloat("_GlitchSy", valy+=.1f);

            if (valy > 100)
                vy = false;
            else vy = true;


        }
        else
        {
            mat.SetFloat("_GlitchSy", valy-=.1f);
            if (valy < 10)
                vy = true;
            else vy = false;

        }


        if (vx)
        {
            mat.SetFloat("_GlitchSx", valx+=.1f);

            if (valx > 15)
                vx = false;
            else vx = true;


        }
        else
        {
            mat.SetFloat("_GlitchSx", valx-=.1f);
            if (valx < 2)
                vx = true;
            else vx = false;

        }



    }
}
