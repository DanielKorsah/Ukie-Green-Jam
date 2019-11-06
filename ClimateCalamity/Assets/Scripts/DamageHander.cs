using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageHander : MonoBehaviour
{

    RedScreen isScreen;

    public GameObject ScreenRed;

    public int PlayerHealth = 100;

    public AudioSource crashSound;
    public AudioClip crash;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {         
            PlayerHealth -= other.gameObject.GetComponent<Enemy>().Damage;
            ScreenRed.GetComponent<RedScreen>().damageTaken = true;
        }
    }


    void Update()
    {
        if (PlayerHealth <= 0)
        {
            StartCoroutine(CrashWait());
        }
    }

    IEnumerator CrashWait()
    {
         crashSound.PlayOneShot(crash, 0.1f);
         yield return new WaitForSeconds(2);
        SceneManager.LoadScene("End Screen");
    }
}
