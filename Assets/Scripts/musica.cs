using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    public AudioClip musicaFondoIntro;
    public AudioClip musicaFondoLoop;
    AudioSource fuenteAudio;
    float tiempoInicio;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        fuenteAudio.clip = musicaFondoIntro;
        fuenteAudio.Play();
        tiempoInicio = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > tiempoInicio+56.059f)
        {
            fuenteAudio.clip = musicaFondoLoop;
            fuenteAudio.Play();
        }
    }
}
