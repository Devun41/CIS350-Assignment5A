/*
 Devun Schneider
 Assignment 5A
 Manages displaying the score to the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public int score = 0;
    public Text textbox;
    public bool won = false;
    // Start is called before the first frame update
    void Start()
    {
        if (textbox == null)
        {
            textbox = FindObjectOfType<Text>();
        }
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
        if (won)
        {
            textbox.text = "Score: " + score + "\n"+"Congrats you won!";
        }
    }
}
