using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class PlayMusic : MonoBehaviour
{

    public AudioClip[] theme;
    public AudioSource themeSource;
    public float bpm = 128;
    
    // Start is called before the first frame update
    void Start()
    {
        themeSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
