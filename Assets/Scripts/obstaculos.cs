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
    int j = 0;
    float positivo = 1.5f;
    float negativo = -1.5f;

    void Start()
    {
        tiempoCambiar1 = Random.Range(1, 3);
        tiempoCambiar2 = Random.Range(1, 3);

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
                clon.transform.position = new Vector3(positivo, 0, i);
                derecha = false;
                j++;
            }
            else
            {
                clon.transform.position = new Vector3(negativo, 0, i);
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
                clon.transform.position = new Vector3(0, positivo, i);
                arriba = false;
                j++;
            }
            else
            {
                clon.transform.position = new Vector3(0, negativo, i);
                arriba = true;
                j++;
            }
        }
    }

    public int a;
    void Update()
    {
        a = Mathf.FloorToInt(Time.time);

        if (a % tiempoCambiar1 == 0)
        {
            if (obstaculos3[0].transform.position.x == negativo)
            {
                obstaculos3[0].transform.position = new Vector3(positivo, 0, obstaculos3[0].transform.position.z);
                obstaculos3[2].transform.position = new Vector3(positivo, 0, obstaculos3[2].transform.position.z);
            }

            else
            {
                obstaculos3[0].transform.position = new Vector3(negativo, 0, obstaculos3[0].transform.position.z);
                obstaculos3[2].transform.position = new Vector3(negativo, 0, obstaculos3[2].transform.position.z);
            }
        }

        if (Mathf.FloorToInt(Time.time) % tiempoCambiar2 == 0)
        {
            if (obstaculos3[1].transform.position.x == negativo)
            {
                obstaculos3[1].transform.position = new Vector3(positivo, 0, obstaculos3[0].transform.position.z);
                obstaculos3[3].transform.position = new Vector3(positivo, 0, obstaculos3[2].transform.position.z);
            }

            else
            {
                obstaculos3[1].transform.position = new Vector3(negativo, 0, obstaculos3[0].transform.position.z);
                obstaculos3[3].transform.position = new Vector3(negativo, 0, obstaculos3[2].transform.position.z);
            }
        }
    }
}
