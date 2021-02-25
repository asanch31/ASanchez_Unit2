﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    private float xboundary = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed );
        if (transform.position.x > xboundary)
        {
            transform.position = new Vector3(xboundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xboundary)
        {
            transform.position = new Vector3(-xboundary, transform.position.y, transform.position.z);
        }
    }
}
