using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{

    public GameObject Objspawn;

    public GameObject Boss;

    public float level = 0;

    public bool inFight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inFight)
        {
            Debug.Log("Boss Spawn Started");
            StartFight();
        }
    }

    void StartFight()
    {
        Objspawn.SetActive(false);

        Instantiate(Boss, new Vector2(9, 0), Quaternion.identity);

        inFight = false;
    }
}
