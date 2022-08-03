using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderRotate : MonoBehaviour
{
    float time = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time <= 110)
            transform.Rotate(Vector3.up * Time.deltaTime * 20f * (time / 60));
        else
            transform.Rotate(Vector3.up * Time.deltaTime * 20f * time/60);
       // Debug.Log(Time.deltaTime * 20f * (time / 60));
    }
}
