﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column_move : MonoBehaviour
{

    float X;
    int fingerCount = 0;
    public static bool tapStart = false;
    public static bool startPos = true;
    public static float positionY;
    public static float positionX;


    // Use this for initialization
    void Start()
    {
        X = 6.83f;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        if (startPos)
        {
            pos.x = 6.83f;
            transform.position = pos;
            X = 6.83f;
            startPos = false;
        }


        if (Input.GetMouseButtonDown(0))
        {
            tapStart = true;
        }

        if (tapStart)
        {
            X -= 0.03f;

            if (X < (-3.3))
            {
                pos.x = 3.37f;
                pos.y = Random.Range(-2.18f, 3.25f);
                positionY = pos.y;
                transform.position = pos;
                X = 3.37f;

            }
            if (X >= -3.3)
            {
                transform.Translate(-0.03f, 0, 0);
                positionX = pos.x;
            }

        }


    }
}