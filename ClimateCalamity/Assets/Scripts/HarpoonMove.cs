using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonMove : MonoBehaviour
{

    public float HarpoonSpeed = 1;

    Rigidbody2D harpbody;

    // Start is called before the first frame update
    void Start()
    {
        harpbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        harpbody.velocity = new Vector3(-2 , HarpoonSpeed, 0);
    }
}
