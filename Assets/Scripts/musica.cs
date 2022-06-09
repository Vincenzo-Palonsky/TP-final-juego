using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    public AudioClip musicaFondo;
    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = musicaFondo;
        fuenteAudio.Play();
    }
}
