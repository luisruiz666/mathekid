using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class controlador : MonoBehaviour
{
    public void CambiarEscena (string nombre)
    {
        
        SceneManager.LoadScene(nombre);
    }

    
    public void salir()
    {
        

        Application.Quit();
    }    
    }

