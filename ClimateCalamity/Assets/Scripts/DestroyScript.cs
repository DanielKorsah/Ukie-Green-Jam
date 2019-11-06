using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    [SerializeField]
    bool canDestroy = false;

    void OnBecameVisible() 
    {       
        canDestroy = true;       
    }

    void OnBecameInvisible()
    {       
        if(canDestroy == true)
        {
            Destroy(gameObject);
        }
    }
}
