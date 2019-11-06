using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    SeedScript seedscript;

    GameObject seedtext;

    public GameObject seed; 

    [SerializeField]
    GameObject Suck;

    [SerializeField]
    private float waitTime = 2;
    Rigidbody2D playerBody;

    [SerializeField]
    private float power = 30;

    private bool canFire = true;

    private bool canSuck = true;

    public float whatlevel = 0;

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
            //Debug.Log(Input.GetAxis("Jump") + ", velocity: " + playerBody.velocity);
        }

        if(whatlevel == 0)
        {

        if(Input.GetKeyDown(KeyCode.Return) && canFire == true)
        {
            Fire();
        }
        }
        else if(whatlevel == 1)
        {
            if(Input.GetKeyDown(KeyCode.Return) && canSuck == true)
            {
                SuckFun();
            }
        }
    }

    void Fire()
    {
         Instantiate(seed, new Vector2(transform.position.x, transform.position.y - 0.5f), Quaternion.identity);
         StartCoroutine(Wait(whatlevel));
    }

    void SuckFun()
    {
        Debug.Log("Suck pressed");
        Suck.SetActive(true);
        StartCoroutine(Wait(whatlevel));
    }

    IEnumerator Wait(float val)
    {
        if(val == 0)
        {
        seedscript.showSeedText = false;
        canFire = false;
        yield return new WaitForSeconds(waitTime);
        canFire = true;
        seedscript.showSeedText = true;
        }
        else if(val == 1)
        {
        canSuck = false;       
        yield return new WaitForSeconds(waitTime);
        Suck.SetActive(false);
        canSuck = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Trash")
        {
            Debug.Log("Trash Destroy");
            Destroy(col);
        }
    }

}
