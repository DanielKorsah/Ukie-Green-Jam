using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonFire : MonoBehaviour
{
    
    public GameObject Harpoon;

    public float SpawnTime = 3;

    private float nextspawn = 0;

    private Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot = transform.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y, rot.z - 90);
        if(Time.time > nextspawn)
        {
            Instantiate(Harpoon, new Vector2(transform.position.x, -2), Quaternion.Euler(rot));
            nextspawn = Time.time + SpawnTime;
        }
    }
}
