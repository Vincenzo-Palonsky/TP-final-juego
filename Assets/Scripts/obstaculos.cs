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
    public int tiempoCambiar1;
    public int tiempoCambiar2;
    int j;
    float positivo = 1.5f;
    float negativo = -1.5f;

    void Start()
    {
        tiempoCambiar1 = Random.Range(3, 6);
        tiempoCambiar2 = Random.Range(3, 6);

        for (int i = 0; i < 80; i += 10)
        {
            GameObject clon = Instantiate(obstaculo1);
            if (derecha)
            {
                clon.transform.position = new Vector3(positivo, 0, i);
                derecha = false;
            }
            else
            {
                clon.transform.position = new Vector3(negativo, 0, i);
                derecha = true;
            }
        }

        for (int i = 95; i < 170; i += 15)
        {
            GameObject clon = Instantiate(obstaculo2);
            if (arriba)
            {
                clon.transform.position = new Vector3(0, positivo, i);
                arriba = false;
            }
            else
            {
                clon.transform.position = new Vector3(0, negativo, i);
                arriba = true;
            }
        }

        j = 0;
        derecha = false;
        for (int i = 185; i <= 230; i += 15)
        {
            obstaculos3[j] = Instantiate(obstaculo1);
            if (derecha)
            {
                obstaculos3[j].transform.position = new Vector3(positivo, 0, i);
                derecha = false;
                j++;
            }
            else
            {
                obstaculos3[j].transform.position = new Vector3(negativo, 0, i);
                derecha = true;
                j++;
            }
        }

        j = 0;
        for (int i = 245; i <= 290; i += 15)
        {
            obstaculos4[j] = Instantiate(obstaculo2);
            if (arriba)
            {
                obstaculos4[j].transform.position = new Vector3(0, positivo, i);
                arriba = false;
                j++;
            }
            else
            {
                obstaculos4[j].transform.position = new Vector3(0, negativo, i);
                arriba = true;
                j++;
            }
        }
    }

    int tiempo1 = 0;
    int tiempo2 = 0;
    void Update()
    {
        if (Mathf.FloorToInt(Time.time) > tiempo1 + tiempoCambiar1)
        {
            if (obstaculos3[0].transform.position.x == negativo)
            {
                obstaculos3[0].transform.position = new Vector3(positivo, 0, 185);
                obstaculos3[2].transform.position = new Vector3(positivo, 0, 215);
            }

            else
            {
                obstaculos3[0].transform.position = new Vector3(negativo, 0, 185);
                obstaculos3[2].transform.position = new Vector3(negativo, 0, 215);
            }

            if (obstaculos4[1].transform.position.y == negativo)
            {
                obstaculos4[1].transform.position = new Vector3(0, positivo, 260);
                obstaculos4[3].transform.position = new Vector3(0, positivo, 290);
            }

            else
            {
                obstaculos4[1].transform.position = new Vector3(0, negativo, 260);
                obstaculos4[3].transform.position = new Vector3(0, negativo, 290);
            }

            tiempo1 += tiempoCambiar1;
        }

        if (Mathf.FloorToInt(Time.time) > tiempo2 + tiempoCambiar2)
        {
            if (obstaculos3[1].transform.position.x == negativo)
            {
                obstaculos3[1].transform.position = new Vector3(positivo, 0, 200);
                obstaculos3[3].transform.position = new Vector3(positivo, 0, 230);
            }

            else
            {
                obstaculos3[1].transform.position = new Vector3(negativo, 0, 200);
                obstaculos3[3].transform.position = new Vector3(negativo, 0, 230);
            }

            if (obstaculos4[0].transform.position.y == negativo)
            {
                obstaculos4[0].transform.position = new Vector3(0, positivo, 245);
                obstaculos4[2].transform.position = new Vector3(0, positivo, 275);
            }

            else
            {
                obstaculos4[0].transform.position = new Vector3(0, negativo, 245);
                obstaculos4[2].transform.position = new Vector3(0, negativo, 275);
            }

            tiempo2 += tiempoCambiar2;
        }
    }
}
