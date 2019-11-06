using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    public AudioSource winsound;

    public AudioClip winclip;

    public GameObject weapon;

    Rigidbody2D rb;

    public float SpawnRate = 3;

    private float nextspawn = 0;

    public float fuelgauge = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, -2, 0);
        InvokeRepeating("AddTime", 1f, 1f);
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

        if(fuelgauge <= 0)
        {
            winsound.PlayOneShot(winclip, 1.0f);
            StartCoroutine(Wait());
        }

    }

    void AddTime()
    {
        fuelgauge -= 1;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

}
