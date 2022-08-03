using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    AudioSource audioSource;
    AudioClip audioClip;
    bool jump;
    bool duck;
    bool duckCheck = true;
    float time = 0f;
    float timePitch = 0f;
    int pitch = 1;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && jump==true)
        {
            audioClip = Resources.Load("Jump") as AudioClip;
            audioSource.clip = audioClip;
            audioSource.Play();
            jump = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && duckCheck)
        {
            //audioSource.Stop();
            audioClip = Resources.Load("Duck") as AudioClip;
            audioSource.clip = audioClip;
            audioSource.Play();
            duck = true;
            duckCheck = false;
        }
        if(duck)
        {
            time += Time.deltaTime;
            if(time>1)
            {
                duck = false;
                time = 0;
                duckCheck = true;
            }
        }
      //  timePitch += Time.deltaTime;
       // 2/60 * timePitch
       // audioSource.pitch = (2 / 60) * timePitch;
       // Debug.Log(audioSource.pitch);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
            jump = true;
    }
}
