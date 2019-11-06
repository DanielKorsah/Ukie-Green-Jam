using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuckScript : MonoBehaviour
{

    GameObject scoreobj;

    Score scorescript;

    void Awake() {
        {
            scoreobj = GameObject.Find("ScoreText");
            if(scoreobj !=  null)
            {
                scorescript = scoreobj.GetComponent<Score>();
            }
        }
    }

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Suck")
        {
            Debug.Log("Trash Entered");
            scorescript.ScoreValue += 5;
            Destroy(gameObject);
        }
    }
}
