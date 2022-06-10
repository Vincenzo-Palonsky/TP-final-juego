using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volverAjugar : MonoBehaviour
{
    public void volver()
    {
        SceneManager.LoadScene("Nivel1");
    }
}