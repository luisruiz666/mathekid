using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class wait : MonoBehaviour
{

    void Start()
    {
        Debug.Log("HOLA");
        StartCoroutine ("esperar");
        
    }



    IEnumerator esperar()
    {
        yield return new WaitForSeconds(45);
        Debug.Log("COMO ESTAS");
        SceneManager.LoadScene("MENU");

    }

}


