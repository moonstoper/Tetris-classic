using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetriBlock : MonoBehaviour
{
    private float previousT;
    public float fallTime = 0.8f;
    public static int width=10;
    public static int height = 20;
    public Vector3 rotationpoint;

    public static int spawnx = 5;
    public static int spawny = 17;
    public static Transform[,] grid = new Transform[width, height];
    int bonus = 0;

    public GameObject ghost;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            LeftT();
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            RightT();
        }
       

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Rotat();
        }
        if (Time.time - previousT > (Input.GetKey(KeyCode.DownArrow) ? fallTime / 10 : fallTime))
        {

            Droop(fallTime);
        }

        

    }



    public void LeftT()
    {
        transform.position = new Vector2(transform.position.x - 1, transform.position.y);
        if (validmove() == false)

            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        FindObjectOfType<Tail>().from_valid(this.gameObject);
        return;
    }
    public void RightT()
    {
        transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        if (validmove() == false)
            transform.position = new Vector2(transform.position.x - 1, transform.position.y);
        FindObjectOfType<Tail>().from_valid(this.gameObject);
        return;
    }

    public void Rotat()
    {
        transform.RotateAround(transform.TransformPoint(rotationpoint), new Vector3(0, 0, 1), 90);
        
        int r = 90;
        if (validmove() == false)
        {
            transform.RotateAround(transform.TransformPoint(rotationpoint), new Vector3(0, 0, 1), -90);
            
            r = -90;
        }
        FindObjectOfType<Tail>().from_valid(this.gameObject);





    }

    public void Droop(float fallt)
    {
        fallTime = fallt;
        transform.position = new Vector2(transform.position.x, transform.position.y - 1);
        FindObjectOfType<Tail>().from_valid(this.gameObject);
        if (validmove() == false)
        {
            Debug.Log("salvation");
            transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            AddToGrid();
            CheckLines();
         
            
                       
            this.enabled = false;
           
            FindObjectOfType<GetTet>().spawnblock();
           





          


        }
        previousT = Time.time;
    }




    void AddToGrid()
    {
            foreach (Transform children in transform)
            {
                int roundedX = Mathf.RoundToInt(children.transform.position.x);
                
                int roundedY = Mathf.RoundToInt(children.transform.position.y);
            
            grid[roundedX, roundedY] = children;
            }

    }
     bool HasLine(int i)
    {
        for(int j=0;j<width;j++)
        {
            if (grid[j, i] == null)
                return false;
        }
        return true;
    }

    public bool HasTop()
    {
        if (grid[5, 17] != null)
            return true;

        return false;
    }

    void CheckLines()
    {
        for(int i=height-1;i>=0;i--)
        {
            if(HasLine(i))
            {   
                DeleteLine(i);
                //
                bonus += 1;
                Debug.Log(bonus);
                RowDown(i);
                
            }
        }
        
        if (bonus != 0)
        {
            FindObjectOfType<Scores>().Scoring(bonus);
            FindObjectOfType<RotatingBack1>().UpdateBack();
            bonus = 0;
        }

        Debug.Log("After Reseting");
    }

    void DeleteLine(int i)
    {
        for(int j=0;j<width;j++)
        {
            Destroy(grid[j,i].gameObject);
            grid[j, i] = null;
        }
    }

    void RowDown(int i)
    {
        for (int y = i; y < height; y++)
        {
            for (int x = 0; x< width; x++)
            {
                if (grid[x, y] != null)
                {
                    grid[x, y - 1] = grid[x, y];
                    grid[x, y] = null;
                   
              
                    grid[x, y - 1].transform.position -= new Vector3(0,1,0);
                   
                }
            }
        }
    }

    public bool validmove()
    {
        
        
        foreach (Transform children in this.transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);

            
            int roundedY = Mathf.RoundToInt(children.transform.position.y);
           
            if (roundedX < 0 || roundedX >= width || roundedY < 0 || roundedY >= height)
            {
                
                return false;
            }
            if (grid[roundedX, roundedY] != null)
                    return false;
        }
        return true;
    }


    
  
}
