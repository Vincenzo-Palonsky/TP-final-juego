using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject obstaculo;
    bool derecha = true;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<50; i+=7)
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
