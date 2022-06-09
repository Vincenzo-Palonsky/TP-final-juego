using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectosSonido : MonoBehaviour
{
    public AudioClip golpe;
    public AudioClip ganar;
    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position.z > 294)
        {
            fuenteAudio.clip = ganar;
            fuenteAudio.Play();
        }
    }

    void OnCollisionEnter()
    {
        fuenteAudio.clip = golpe;
        fuenteAudio.Play();
    }
}
