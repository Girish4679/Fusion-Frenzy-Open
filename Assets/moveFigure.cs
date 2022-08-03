using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFigure : MonoBehaviour
{
    // Start is called before the first frame update
    float timeSize = 0f;
    bool down;
    bool jump;

    public float jumpVelocity;
    void Start()
    {
        jumpVelocity = 10f;
 
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Input.GetKeyDown(KeyCode.UpArrow) && jump==true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            jump = false;
        }    
       
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
           transform.localScale = new Vector3(transform.localScale.x, 0.25f, transform.localScale.z);
           down = true;
          // transform.Rotate(-80, 120, 0);
        }
        if(down)
        {
            timeSize += Time.deltaTime;
         //   Debug.Log(timeSize);
            if (timeSize>1)
            {
                transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
                down = false;
              //  transform.Rotate(0, 120, 0);
                timeSize = 0f;
            }
        }

        if (transform.position.x < -7.216654 && transform.position.z> -8.704716)
            Application.LoadLevel(0);
        
        

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
            jump = true;
    }

}
