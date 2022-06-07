using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float velocidadMov = 0.1f;
    float aumentarVelocidad = 0.1f;
    public GameObject jugador;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, velocidadMov*aumentarVelocidad);
        aumentarVelocidad = aumentarVelocidad + 0.05f;

        if (Time.time>2)
        {
            if (transform.position.z < -15.7f)
            {
                aumentarVelocidad = 0.1f;
            }
        }
    }
}
