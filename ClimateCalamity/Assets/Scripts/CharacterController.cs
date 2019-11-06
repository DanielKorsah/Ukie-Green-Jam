using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody2D playerBody;

    [SerializeField]
    private float power = 30;

    private void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            playerBody.AddForce(new Vector3(0, power, 0));
            Debug.Log(Input.GetAxis("Jump") + ", velocity: " + playerBody.velocity);
        }
    }
}
