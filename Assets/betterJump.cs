using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterJump : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 3f;
    float time = 0f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(rb.velocity.y < 0)
        {
            float value = (fallMultiplier - 1) + ((7.5f * time) / 60f);
            Debug.Log(value);
            if(time<=60)
                rb.velocity += Vector3.up * Physics.gravity.y * value * Time.deltaTime;
            else
                rb.velocity += Vector3.up * Physics.gravity.y * (9) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        time += Time.deltaTime;
    }
}
