using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    SeedScript seedscript;

    GameObject seedtext;

    public GameObject seed; 

    [SerializeField]
    private float waitTime = 2;
    Rigidbody2D playerBody;

    [SerializeField]
    private float power = 30;

    private bool canFire = true;

    private void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
        seedtext = GameObject.Find("SeedText");
        if(seedtext != null)
        {
            seedscript = GameObject.Find("SeedText").GetComponent<SeedScript>();
            seedscript.showSeedText = true;
        }
    }
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            playerBody.AddForce(new Vector3(0, power, 0));
            Debug.Log(Input.GetAxis("Jump") + ", velocity: " + playerBody.velocity);
        }

        if(Input.GetKeyDown(KeyCode.Return) && canFire == true)
        {
            Fire();
        }
    }

    void Fire()
    {
         Instantiate(seed, new Vector2(transform.position.x, transform.position.y - 0.5f), Quaternion.identity);
         StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        seedscript.showSeedText = false;
        canFire = false;
        yield return new WaitForSeconds(waitTime);
        canFire = true;
        seedscript.showSeedText = true;
    }


}
