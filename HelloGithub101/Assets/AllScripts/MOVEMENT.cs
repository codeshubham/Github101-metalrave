﻿/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class MOVEMENT : MonoBehaviour
{
    public Rigidbody rb;
    public float frontforce = 2000f;
    public float sideforce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, frontforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("p"))
        {
            rb.AddForce(0, 0.5f, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<Restartgame>().endgame();
        }
    }
}
