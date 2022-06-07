using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float velocidadMov = 0.1f;
    float aumentarVelocidad = 1;
    public GameObject jugador;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, velocidadMov*aumentarVelocidad);
        aumentarVelocidad = aumentarVelocidad + 0.2f;
    }
}
