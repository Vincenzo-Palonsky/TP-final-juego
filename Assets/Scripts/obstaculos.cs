using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject obstaculo1;
    public GameObject obstaculo2;
    public GameObject obstaculo3;
    bool derecha = true;
    bool arriba = true;
    bool esquinaDer = true;

    void Start()
    {
        for (int i = 0; i < 80; i += 10)
        {
            GameObject clon = Instantiate(obstaculo1);
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

        for (int i = 100; i < 180; i += 10)
        {
            GameObject clon = Instantiate(obstaculo1);
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
    }

    void Update()
    {
        
    }
}
