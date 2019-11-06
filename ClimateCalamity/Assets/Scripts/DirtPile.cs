﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPile : MonoBehaviour
{
    GameObject scoreobj;

    Score scorescript;

     void Awake()
    {
        scoreobj = GameObject.Find("ScoreText");
        if(scoreobj != null)
        {
            scorescript = scoreobj.GetComponent<Score>();
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Seed")
        {
            scorescript.ScoreValue += 5;
            Destroy(collider.gameObject);

        }
    }
}
