using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{

    public AudioSource crashSound;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        crashSound = audios[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
