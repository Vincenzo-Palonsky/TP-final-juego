using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public GameObject obstaculo;
    Vector3 posInicial, posInicialCam;
    float aumentarVelocidad = 0.1f;
    int vidas = 3;
    public Text mostrarVidas;
    public Text mostrarPerdiste;
    public GameObject cartelPerdiste;
    float tiempoMuerte;
    float tiempoChoque;
    public camera cam;

    void Start()
    {
        posInicial = transform.position;
        posInicialCam = cam.transform.position;
        cartelPerdiste.SetActive(false);
    }

    void Update()
    {
        if (Time.time > tiempoMuerte+3)
        {
            transform.position += new Vector3(0, 0, 0.05f*aumentarVelocidad);
            aumentarVelocidad = aumentarVelocidad + 0.05f;
            cartelPerdiste.SetActive(false);

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != 1.5)
            {
                transform.position += new Vector3(0, 1.5f, 0);
            }

            if (Input.GetKeyDown(KeyCode.W) && transform.position.y != 1.5)
            {
                transform.position += new Vector3(0, 1.5f, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -1.5)
            {
                transform.position -= new Vector3(0, 1.5f, 0);
            }

            if (Input.GetKeyDown(KeyCode.S) && transform.position.y != -1.5)
            {
                transform.position -= new Vector3(0, 1.5f, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -1.5)
            {
                transform.position -= new Vector3(1.5f, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -1.5)
            {
                transform.position -= new Vector3(1.5f, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != 1.5)
            {
                transform.position += new Vector3(1.5f, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 1.5)
            {
                transform.position += new Vector3(1.5f, 0, 0);
            }
        }
    }

    void OnCollisionEnter(Collision final)
    {
        transform.position = new Vector3(0, 0, transform.position.z + 2);
        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + 2);

        vidas--;
        mostrarVidas.text = "Vidas restantes: " + vidas.ToString();
        if (vidas == 0)
        {
            transform.position = posInicial;
            cam.transform.position = posInicialCam;
            tiempoMuerte = Time.time;
            cam.tiempoMuerte = Time.time;
            cartelPerdiste.SetActive(true);
            aumentarVelocidad = 0.1f;
            cam.aumentarVelocidad = 0.1f;
            vidas = 3;
            mostrarVidas.text = "Vidas restantes: " + vidas.ToString();
        }

        if (final.gameObject.name == "meta")
        {
            SceneManager.LoadScene("Ganar");
        }
    }
}
