using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{

    public float lerpspeed = 2.0f;

    Rigidbody2D mbody;

    // Start is called before the first frame update
    void Start()
    {
        mbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mbody.velocity = Vector3.Lerp(new Vector3(-5, 0, 0), Vector3.zero, lerpspeed * Time.deltaTime);
    }
}
