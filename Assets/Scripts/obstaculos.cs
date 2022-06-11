using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject obstaculo1;
    public GameObject obstaculo2;
    bool derecha = true;
    bool arriba = true;
    GameObject[] obstaculos3 = new GameObject[4];
    GameObject[] obstaculos4 = new GameObject[4];
    int j = 0;

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

        for (int i = 95; i < 170; i += 15)
        {
            GameObject clon = Instantiate(obstaculo2);
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

        for (int i = 0; i < 4; i ++)
        {
            obstaculos3[i] = obstaculo1;
            obstaculos4[i] = obstaculo2;
        }

        derecha = false;
        for (int i = 185; i <= 230; i += 15)
        {
            GameObject clon = Instantiate(obstaculos3[j]);
            if (derecha)
            {
                clon.transform.position = new Vector3(1.5f, 0, i);
                derecha = false;
                j++;
            }
            else
            {
                clon.transform.position = new Vector3(-1.5f, 0, i);
                derecha = true;
                j++;
            }
        }

        j = 0;
        for (int i = 245; i <= 290; i += 15)
        {
            GameObject clon = Instantiate(obstaculos4[j]);
            if (arriba)
            {
                clon.transform.position = new Vector3(0, 1.5f, i);
                derecha = false;
                j++;
            }
            else
            {
                clon.transform.position = new Vector3(0, -1.5f, i);
                derecha = true;
                j++;
            }
        }
    }

    void Update()
    {

    }
}
