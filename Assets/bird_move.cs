using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird_move : MonoBehaviour {

    public AudioClip sound1;

    public AudioSource soundSource1;

    public AudioClip sound2;

    public AudioSource soundSource2;

    int fingerCount = 0;
    float X;
    bool birdMove = false;
   // bool newGame = false;
    bool scored = false;
    float fall;
    float goUp;

    public Text scoreText;
    public int score = 0;

    // Use this for initialization
    void Start () {

        X = 0;
    }
	
	// Update is called once per frame
	void Update () {

        scoreText.text = score.ToString();

        var pos = transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            fall = -0.04f;
            goUp = 0.08f;
            soundSource1.clip = sound1;
            soundSource1.Play();
            birdMove = true;
            X = 0;
        }

        if (pos.y < -3.35)
        {
            newGame();
        }

        if (birdMove)
        {
            //pos = transform.position;
            if ((pos.y <= column_move.positionY - 0.578f
                || pos.y >= column_move.positionY + 0.837f)
                && (0.57 >= column_move.positionX
                && -0.44 <= column_move.positionX)
                && score % 2 != 0)
            {
                newGame();
            }
            else if (-0.92 <= column_move.positionX && -0.910 >= column_move.positionX)
            {
                score++;
            }
            if ((pos.y <= column1_move.positionY - 0.578f || 
                pos.y >= column1_move.positionY + 0.837f) && 
                (0.57 >= column1_move.positionX && 
                -0.44 <= column1_move.positionX) &&
                score % 2 == 0)
            { 
                newGame();
}
            else if (-0.82 >= column1_move.positionX && -0.83 <= column1_move.positionX)
            {
                score++;
            }
            

            if (X <= 1.2)
            {
                transform.Translate(0, +0.05f, 0);
                X += 0.05f;
                goUp -= 0.003f;
            }
            if (X > 1.2)
            {
                
                transform.Translate(0, fall, 0);
                fall -= 0.003f;

            }
        }
        
        
        
    }


    void newGame()
    {
        var pos = transform.position;
        birdMove = false;
        footer_move.tapStart = false;
        column1_move.tapStart = false;
        column_move.tapStart = false;
        score = 0;
        column1_move.startPos = true;
        column_move.startPos = true;
        soundSource2.clip = sound2;
        soundSource2.Play();
        pos.y = 0;
        transform.position = pos;
        X = 0;
    }


}
