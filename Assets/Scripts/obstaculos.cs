using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject obstaculo;
    bool derecha = true;
    bool arriba = true;
    bool esquinaDer = true;

    void Start()
    {
        for (int i = 0; i < 50; i += 7)
        {
            GameObject clon = Instantiate(obstaculo);
            if (derecha)
            {
                clon.transform.position = new Vector3(1.5f, 0, i);
                derecha = false;
            }
            else
            {
                clon.transform.position = new Vector3(-1.5f, 0, i);
                derecha = true;
            }
        }

        for (int i = 70; i < 120; i += 7)
        {
            GameObject clon = Instantiate(obstaculo);
            if (arriba)
            {
                clon.transform.position = new Vector3(0, 1.5f, i);
                arriba = false;
            }
            else
            {
                clon.transform.position = new Vector3(0, -1.5f, i);
                arriba = true;
            }
        }

        for (int i = 140; i < 170; i += 7)
        {
            GameObject clon = Instantiate(obstaculo);
            if (esquinaDer)
            {
                clon.transform.position = new Vector3(1.5f, 1.5f, i);
                esquinaDer = false;
            }
            else
            {
                clon.transform.position = new Vector3(-1.5f, -1.5f, i);
                esquinaDer = true;
            }
        }
    }

    void Update()
    {
        
    }
}
