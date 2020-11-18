using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZonaInteraccion : MonoBehaviour
{
    public string textoInteraccion;
    public Text textoInteracciones;

    void OnMouseEnter()
    {
        textoInteracciones.text = textoInteraccion;    
    }
    void OnMouseExit()
    {
        textoInteracciones.text = "";    
    }
}
