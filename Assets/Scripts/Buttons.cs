using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update

    public void mLeft()
    {   
        Debug.Log("Buttons clicked");
       // foreach()
       
            FindObjectOfType<TetriBlock>().LeftT();
        return;
    }

    public void mRight()
    {
        FindObjectOfType<TetriBlock>().RightT();

    }

    public void Rotate()
    {
        FindObjectOfType<TetriBlock>().Rotat();
    }

    public void Drop()
    {   
        FindObjectOfType<TetriBlock>().Droop();
    }
}
