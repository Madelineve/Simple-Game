using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footer_move : MonoBehaviour {
    float X;
    int fingerCount = 0;
    public static bool tapStart = false;

    // Use this for initialization
    void Start () {
        X = 0.4f;
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            tapStart = true;
        }

        if (tapStart)
        {
            X -= 0.03f;

            if (X < (-0.43))
            {
                var pos = transform.position;
                pos.x = 0.5465f;
                transform.position = pos;
                X = 0.5465f;
            }
            if (X <= 0.5465f && X >= -0.43) transform.Translate(-0.03f, 0, 0);

        }
    }
}
