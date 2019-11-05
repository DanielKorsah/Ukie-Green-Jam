using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Scroller : MonoBehaviour
{



    public Vector2 speed = new Vector2(3, 3);

    public Vector2 direction = new Vector2(-1, 0);

    public bool cameraLink = false;
    
    public bool loop = false;
    private List<SpriteRenderer> backgroundstuff;

    void Start() 
    {
        if(loop)
        {
            backgroundstuff = new List<SpriteRenderer>();

            for(int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                SpriteRenderer r = child.GetComponent<SpriteRenderer>();

                if(r != null) 
                {
                    backgroundstuff.Add(r);
                }
            }

            backgroundstuff = backgroundstuff.OrderBy(t => t.transform.position.x).ToList();

        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(
            speed.x * direction.x, speed.y * direction.y, 0
        );

        movement *= Time.deltaTime;
        transform.Translate(movement);
        
        if(cameraLink == true)
        {
            Camera.main.transform.Translate(movement);
        }

        if(loop)
        {
            SpriteRenderer child1 = backgroundstuff.FirstOrDefault();

            if(child1 != null)
            {
                
                if(child1.transform.position.x < Camera.main.transform.position.x)
                {
                    if(child1.isVisibleFrom(Camera.main) == false)
                    {
                        SpriteRenderer lastchild = backgroundstuff.LastOrDefault();

                        Vector3 lastPos = lastchild.transform.position;
                        Vector3 lastSize = (lastchild.bounds.max - lastchild.bounds.min);

                        child1.transform.position = new Vector3(lastPos.x + lastSize.x, child1.transform.position.y, child1.transform.position.z);

                        backgroundstuff.Remove(child1);
                        backgroundstuff.Add(child1);
                    }
                }

            }
        }


    }
}
