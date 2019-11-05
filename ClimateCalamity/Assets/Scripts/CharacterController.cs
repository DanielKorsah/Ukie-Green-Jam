using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public GameObject seed; 
    Rigidbody2D playerBody;

    [SerializeField]
    private float power = 30;

    private bool canFire = true;

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

        if(Input.GetButton("Fire1") && canFire == true)
        {
            Fire();
        }
    }

    void Fire()
    {
         Instantiate(seed, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
         StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        canFire = false;
        yield return new WaitForSeconds(5);
        canFire = true;
    }


}
