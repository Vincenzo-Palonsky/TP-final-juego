using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class festejo : MonoBehaviour
{
    public AudioClip aplausos;
    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = aplausos;
        fuenteAudio.Play();
    }
}
