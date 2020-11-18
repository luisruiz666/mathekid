using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textocuadro : MonoBehaviour
{
    public string content_text="hola";
    public Text texto_cuadro;
    public Text texto_cuadro1;
    public Text texto_cuadro2;
    public GameObject boton;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject cuadro;
    public GameObject cuadro1;
    public GameObject cuadro2;
    public GameObject caranormal;
    public GameObject caratriste;
    public GameObject carafeliz;

    void Start()
    {
        cuadro.SetActive(false);
        cuadro1.SetActive(false);
        cuadro2.SetActive(false);
        

    }
    public void Showtext()
    {
        texto_cuadro.text = texto_cuadro.text;
        cuadro.SetActive(true);
        cuadro1.SetActive(false);
        cuadro2.SetActive(false);
        caranormal.SetActive(true);

    }
    public void Showtext1()
    {
        texto_cuadro1.text = texto_cuadro1.text;
        cuadro1.SetActive(true);
        cuadro.SetActive(false);
        cuadro2.SetActive(false);
        caranormal.SetActive(true);

    }
    public void Showtext2()
    {
        texto_cuadro2.text = texto_cuadro2.text;
        cuadro2.SetActive(true);
        cuadro.SetActive(false);
        cuadro1.SetActive(false);
        caranormal.SetActive(true);
    }
    public void Cerrartext()
    {
        cuadro.SetActive(false);
        boton.SetActive(true);
    }
    public void Cerrartext1()
    {
        cuadro1.SetActive(false);
        boton1.SetActive(true);
    }
    public void Cerrartext2()
    {
        cuadro2.SetActive(false);
        boton2.SetActive(true);
    }
}
