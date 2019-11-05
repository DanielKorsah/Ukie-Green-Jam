﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHander : MonoBehaviour
{

    public int PlayerHealth = 100;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            PlayerHealth -= other.gameObject.GetComponent<Enemy>().Damage;
        }
    }


    void Update()
    {
        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}