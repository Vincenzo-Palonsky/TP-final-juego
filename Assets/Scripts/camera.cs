using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float aumentarVelocidad = 0.1f;
    public float tiempoMuerte;
    public GameObject jugador;

    void Update()
    {
        if(Time.time > tiempoMuerte + 3)
        {
            transform.position += new Vector3(0, 0, 0.05f * aumentarVelocidad);
            aumentarVelocidad = aumentarVelocidad + 0.05f;
        }        
    }
}
