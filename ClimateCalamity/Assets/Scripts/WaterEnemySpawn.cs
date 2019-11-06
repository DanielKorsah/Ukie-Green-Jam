using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnemySpawn : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
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
            enemyType = Random.Range(0,3);
            randT = Random.Range(1, 5);
            if (enemyType == 0 || enemyType == 1)
            {
                randY = Random.Range(-4, 4);
                whereToSpawn = new Vector2(20, randY);
                Instantiate(enemy1, whereToSpawn, Quaternion.identity);
            }
            else if (enemyType == 2)
            {
                whereToSpawn = new Vector2(20, -3f);
                Instantiate(enemy2, whereToSpawn, Quaternion.identity);
            }
            nextSpawn = Time.time + randT;
        }
    }
}
