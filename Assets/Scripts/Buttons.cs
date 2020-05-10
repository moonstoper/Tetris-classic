using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Buttons : MonoBehaviour, IPointerClickHandler, IPointerUpHandler,IPointerDownHandler
{
    // Start is called before the first frame update

    int btn_number;
    public bool isPressed = false;
    Button BL;
    Button BR, BD, B0;
    float timer;
    float timeMax = 0.8f;
    float ctime;

    public void Start()
    {
        BL = GameObject.Find("mLeft").GetComponent<Button>();
        BR = GameObject.Find("mRight").GetComponent<Button>();
        BD = GameObject.Find("mdroop").GetComponent<Button>();
        B0 = GameObject.Find("mRotate").GetComponent<Button>();
        

    }

    void Update()
    {



           if(btn_number!=0)
            switch (btn_number)
            {
                case 1:
                    mLeft();
                    break;

                case 2:
                    mRight();
                    break;

                case 3:
                    Rotate();
                    break;

                case 4:
                    if (Time.time-timer<ctime &&isPressed == true)
                    Drop(timeMax/10);
                    ctime = Time.time;
                
                break;

                default: break;
            }



        btn_number = 0;
        timer = Time.time;

    }


  

    public void mLeft()
    {   
        //Debug.Log("Buttons clicked");
       // foreach()
       
            FindObjectOfType<TetriBlock>().LeftT();
   

    }

    public void mRight()
    {
        FindObjectOfType<TetriBlock>().RightT();
     
    }

    public void Rotate()
    {
        FindObjectOfType<TetriBlock>().Rotat();
        

   
    }

    public void Drop(float falltime)
    {
        
        FindObjectOfType<TetriBlock>().Droop(falltime);
        
        
    

    }


   

    public void OnPointerClick(PointerEventData eventData)
    {
        isPressed = true;


        if (eventData.pointerCurrentRaycast.gameObject.name == BL.name)
            btn_number = 1;

        if (eventData.pointerCurrentRaycast.gameObject.name == BR.name)
            btn_number = 2;

        if (eventData.pointerCurrentRaycast.gameObject.name == B0.name)
            btn_number = 3;
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.name == BD.name)
        {
            btn_number = 4;
            isPressed = true;
            ctime = Time.time;
            Debug.Log("Pressed");

        }

    }


    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();

        btn_number = 0;
        isPressed = false;
        

    }

  
}
