using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    int pitch = 1;
    float time = 0f;
    float val = 2f / 60f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float pitchVal = pitch + (val * time);
        audioSource.pitch = pitchVal;
        Debug.Log(pitchVal);
        
        
       
    }
}
