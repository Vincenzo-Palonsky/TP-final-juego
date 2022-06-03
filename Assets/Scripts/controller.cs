using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject obstaculo;
    public int vidas = 3;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0,0,0.1f);

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
        if (obs.gameObject == obstaculo)
        {
            Destroy(obstaculo, 0);
            Destroy(GetComponent<Rigidbody>());
            transform.position = new Vector3(0,0,transform.position.z+2);
        }
        vidas--;
    }
}
