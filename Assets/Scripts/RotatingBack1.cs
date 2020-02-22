using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBack1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] colour = new Color[8];
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateBack()
    {
        //Color c = ;
        GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, colour[Random.Range(0, 7)],30);
        
    }
}
