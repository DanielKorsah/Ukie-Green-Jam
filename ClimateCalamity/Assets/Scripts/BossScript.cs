using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    public GameObject weapon;

    Rigidbody2D rb;

    public float SpawnRate = 3;

    private float nextspawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, -2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -3.5)
        {
           // transform.Translate(new Vector3(5, transform.position.y, transform.position.z));
            rb.velocity = new Vector3(0, 2, 0);
        }

        if(transform.position.y > 3.5)
        {
         //   transform.Translate(new Vector3(5, transform.position.y, transform.position.z));
            rb.velocity = new Vector3(0, -2, 0);
        }

       if(Time.time > nextspawn)
       {
           Instantiate(weapon, new Vector2(transform.position.x + 8, transform.position.y), Quaternion.identity);
           nextspawn = Time.time + SpawnRate;
       } 

    }
}
