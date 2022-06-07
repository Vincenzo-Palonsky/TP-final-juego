using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    public AudioClip musicaFondoIntro;
    public AudioClip musicaFondoLoop;
    AudioSource fuenteAudio;
    float tiempoInicio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = musicaFondoIntro;
        fuenteAudio.Play();
        tiempoInicio = Time.time;
    }

    void Update()
    {
        if (Time.time > tiempoInicio+56.059f)
        {
            fuenteAudio.clip = musicaFondoLoop;
            fuenteAudio.Play();
        }
    }
}
