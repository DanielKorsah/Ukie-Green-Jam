using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScreen : MonoBehaviour
{

    Color opaque;
    Color Transparent;

    public bool damageTaken = false;

    public float Lerptime = 1;

    SpriteRenderer thisSprite;

    // Start is called before the first frame update
    void Start()
    {
        opaque = new Color(1, 1, 1, 1);
        Transparent = new Color(1, 1, 1, 0);
        thisSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(damageTaken == true)
        {
            opaque = new Color(1, 0, 0, 1);
            Debug.Log("goign red");
            thisSprite.color = Color.Lerp(thisSprite.color, opaque, Lerptime * Time.deltaTime);
            if(thisSprite.color.a >= 0.8)
            {
                damageTaken = false;
            }
        }

        if(damageTaken == false)
        {
        Transparent = new Color(1, 0, 0, 0);
           thisSprite.color = Color.Lerp(thisSprite.color, Transparent, Lerptime * Time.deltaTime);
        }

    }
}
