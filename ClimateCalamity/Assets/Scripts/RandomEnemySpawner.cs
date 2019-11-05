using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randY;
    float randT;

    //Using a random number generator to select which character to spawn 
    float enemyType;
    Vector2 whereToSpawn;
    float nextSpawn=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            enemyType = Random.Range(0,1);
            if (enemyType == 0)
            {
                randT = Random.Range(1, 9);
                randY = Random.Range(-4, 4);
                whereToSpawn = new Vector2(20, randY);
            }
            else if (enemyType == 1)
            {
                randT = Random.Range(1, 1);
                randY = Random.Range(-4, 4);
                whereToSpawn = new Vector2(20, randY);
            }
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            nextSpawn = Time.time + randT;
        }
    }
}
