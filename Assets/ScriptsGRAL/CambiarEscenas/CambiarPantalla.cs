using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarPantalla : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void EscenaCreditos()
    {
        SceneManager.LoadScene(2);
    }

    public void Salir()
    {
        Application.Quit();
    }


}
