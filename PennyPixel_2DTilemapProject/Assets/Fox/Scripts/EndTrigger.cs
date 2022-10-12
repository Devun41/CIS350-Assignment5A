/*
 Devun Schneider
 Assignment 5A
 Manages the player reaching the end of the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public DisplayScore displayScoreScript;
    // Start is called before the first frame update
    void Start()
    {
        displayScoreScript = FindObjectOfType<DisplayScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("FinishLine"))
        {
            displayScoreScript.won = true;
        }
    }
    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("FinishLine"))
        {
            displayScoreScript.won = true;

        }
    }
}
