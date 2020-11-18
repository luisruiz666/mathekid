using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textoautomatico : MonoBehaviour
{
    public string frase = "ola k ase";
    public Text texto;
    
    void Start()
    {
       

        StartCoroutine(Reloj());


        
    }
    IEnumerator Reloj()
    {
       foreach (char caracter in frase)
        {
            
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }

        
    }
   
}
