﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(-7f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(7f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, 7f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(0f, -7f * Time.deltaTime, 0f);
        }
    }
}
