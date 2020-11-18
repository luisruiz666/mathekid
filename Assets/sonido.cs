using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    public AudioSource source;
    public AudioClip escena;
    void Start()
    {
        source.clip = escena;
        source.Play();
    }

    
    void Update()
    {
        
    }
}
