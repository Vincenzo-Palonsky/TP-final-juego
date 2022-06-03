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

    void Start()
    {
        posInicial = transform.position;
        posInicialCam = camara.transform.position;
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
        if (vidas == 0)
        {
            Debug.Log("perdiste");
            transform.position = posInicial;
            camara.transform.position = posInicialCam;
            vidas--;
            mostrarVidas.text = "Vidas restantes: " + vidas.ToString();
        }
    }
}
