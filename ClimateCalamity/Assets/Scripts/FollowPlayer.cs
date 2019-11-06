﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(player.transform.position.x, player.transform.position.y, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(player.transform.position.x, player.transform.position.y, 0));
    }
}
