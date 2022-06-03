using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    public GameObject obstaculo;
    public GameObject camara;
    Vector3 posInicial, posInicialCam;
    float velocidadMov = 0.1f;
    int vidas = 3;
    public Text mostrarVidas;
    public Text mostrarGanaste;
    public Text mostrarPerdiste;
    public GameObject cartelGanaste;
    public GameObject cartelPerdiste;

    void Start()
    {
        posInicial = transform.position;
        posInicialCam = camara.transform.position;
        cartelGanaste.SetActive(false);
        cartelPerdiste.SetActive(false);
    }

    void Update()
    {
        transform.position += new Vector3(0,0,velocidadMov*Time.time);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y!=1.5)
        {
            transform.position += new Vector3(0, 1.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.S) && transform.position.y != -1.5)
        {
            transform.position -= new Vector3(0, 1.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -1.5)
        {
            transform.position -= new Vector3(1.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 1.5)
        {
            transform.position += new Vector3(1.5f, 0, 0);
        }
    }

    void OnCollisionEnter(Collision obs)
    {
        transform.position = new Vector3(0, 0, transform.position.z + 2);
        camara.transform.position = new Vector3(camara.transform.position.x, camara.transform.position.y, camara.transform.position.z + 2);

        vidas--;
        mostrarVidas.text = "Vidas restantes: " + vidas.ToString();
        if (vidas == 0)
        {
            transform.position = posInicial;
            camara.transform.position = posInicialCam;
        }
    }
}
