using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPile : MonoBehaviour
{

    public GameObject pile;

    float chancetospawn;
    private float nextSpawn = 0;
    private float randtime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            chancetospawn = Random.Range(0, 5);
            randtime = Random.Range(2, 4);

            if(chancetospawn == 0)
            {
                Instantiate(pile, new Vector2(20, -3), Quaternion.identity);
            }
            nextSpawn = Time.time + randtime;
        }
    }
}
