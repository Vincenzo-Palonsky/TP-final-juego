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
        tiempoCambiar1 = Random.Range(3, 5);
        tiempoCambiar2 = Random.Range(3, 5);

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

    float tiempo = 0;
    void Update()
    {
        tiempo = Mathf.FloorToInt(Time.time);
        Debug.Log(tiempo);
        if (tiempo % 4 == 0)
        {
            if (obstaculos3[0].transform.position.x == negativo)
            {
                obstaculos3[0].transform.position = new Vector3(positivo, 0, 185);
                obstaculos3[2].transform.position = new Vector3(positivo, 0, 215);
                tiempo = -1;
            }

            else
            {
                obstaculos3[0].transform.position = new Vector3(negativo, 0, 185);
                obstaculos3[2].transform.position = new Vector3(negativo, 0, 215);
                tiempo = -1;
            }
        }

        //if (Mathf.FloorToInt(Time.time) % tiempoCambiar2 == 0)
        //{
        //    if (obstaculos3[1].transform.position.x == negativo)
        //    {
        //        obstaculos3[1].transform.position = new Vector3(positivo, 0, obstaculos3[0].transform.position.z);
        //        obstaculos3[3].transform.position = new Vector3(positivo, 0, obstaculos3[2].transform.position.z);
        //    }

        //    else
        //    {
        //        obstaculos3[1].transform.position = new Vector3(negativo, 0, obstaculos3[0].transform.position.z);
        //        obstaculos3[3].transform.position = new Vector3(negativo, 0, obstaculos3[2].transform.position.z);
        //    }
        //}
    }
}
