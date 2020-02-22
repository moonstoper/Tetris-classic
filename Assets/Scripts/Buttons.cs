using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IPointerExitHandler
{
    // Start is called before the first frame update

    public float durationThreshold = 0.05f;
    public float timer;
    public bool isPressed = false;

    //public UnityEvent onLongPres;

    void FixedUpdate()
    {
        if (isPressed)
        {
            Debug.Log("Indrop");
            if (Time.time - timer > durationThreshold)
            {
                isPressed = false;
                FindObjectOfType<TetriBlock>().Droop(0.8f / 10);
            }




        }
    }

    public void mLeft()
    {   
        //Debug.Log("Buttons clicked");
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
    { timer = Time.time;
        isPressed = true;

        FixedUpdate();
       

    }

   

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();

        isPressed = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPressed = false;
    }
}
