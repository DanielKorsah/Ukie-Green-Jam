﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageHander : MonoBehaviour
{

    public int PlayerHealth = 100;

    public AudioSource crashSound;
    public AudioClip crash;

    RedScreen isScreen;

    public GameObject ScreenRed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {         
            PlayerHealth -= other.gameObject.GetComponent<Enemy>().Damage;
            ScreenRed.GetComponent<RedScreen>().damageTaken = true;
        }

        if (PlayerHealth <= 0)
        {
            StartCoroutine(CrashWait());
        }
    }

    IEnumerator CrashWait()
    {
         crashSound.PlayOneShot(crash, 0.1f);
        Destroy(gameObject);
         yield return new WaitForSeconds(2);
        SceneManager.LoadScene("End Screen");
    }
}