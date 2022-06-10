﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectosSonido : MonoBehaviour
{
    public AudioClip golpe;
    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        fuenteAudio.clip = golpe;
        fuenteAudio.Play();
    }
}
