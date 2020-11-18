using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class Manager : MonoBehaviour
{

    public GameObject panda1, panda2, panda3, panda4, panda5, panda6, espacio1, espacio2, espacio3, espacio4, espacio5, espacio6;
    public GameObject gameover;
    public GameObject reinicio;
    public GameObject volver;
    public GameObject caranormal;
    public GameObject carafeliz;
    public GameObject caratriste;
    public GameObject carapensar;

    public int puntaje = 1;

    Vector2 panda1InitialPos, panda2InitialPos, panda3InitialPos, panda4InitialPos, panda5InitialPos, panda6InitialPos;

    public AudioSource source;

    public AudioClip[] correct;
    public AudioClip incorrect;

    bool panda1Correct, panda2Correct, panda3Correct, panda4Correct, panda5Correct, panda6Correct  = false;



    private void Start()
    {
        caranormal.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        carapensar.SetActive(false);
        gameover.SetActive(false);
        reinicio.SetActive(false);
        volver.SetActive(false);
       
        panda1InitialPos = panda1.transform.position;
        panda2InitialPos = panda2.transform.position;
        panda3InitialPos = panda3.transform.position;
        panda4InitialPos = panda4.transform.position;
        panda5InitialPos = panda5.transform.position;
        panda6InitialPos = panda6.transform.position;
        
       

    }

    public void Dragpanda1()
    {
        panda1.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);


    }
    public void Dragpanda2()
    {
        panda2.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);

    }
    public void Dragpanda3()
    {
        panda3.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);

    }
    public void Dragpanda4()
    {
        panda4.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);

    }
    public void Dragpanda5()
    {
        panda5.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);
    }
    public void Dragpanda6()
    {
        panda6.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);
    }



    public void Droppanda1()
    {
        float Distance = Vector3.Distance(panda1.transform.position, espacio1.transform.position);
        if(Distance<50)
        {
            panda1.transform.position = espacio1.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
          
            panda1Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            panda1.transform.position = panda1InitialPos;
            gamecontrol.Scorre += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    public void Droppanda2()
    {
        float Distance = Vector3.Distance(panda2.transform.position, espacio2.transform.position);
        if (Distance < 50)
        {
            panda2.transform.position = espacio2.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            panda2Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            panda2.transform.position = panda2InitialPos;
            gamecontrol.Scorre += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    public void Droppanda3()
    {
        float Distance = Vector3.Distance(panda3.transform.position, espacio3.transform.position);
        if (Distance < 50)
        {
            panda3.transform.position = espacio3.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            panda3Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            panda3.transform.position = panda3InitialPos;
            gamecontrol.Scorre += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    public void Droppanda4()
    {
        float Distance = Vector3.Distance(panda4.transform.position, espacio4.transform.position);
        if (Distance < 50)
        {
            panda4.transform.position = espacio4.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            panda4Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            panda4.transform.position = panda4InitialPos;
            gamecontrol.Scorre += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    public void Droppanda5()
    {
        float Distance = Vector3.Distance(panda5.transform.position, espacio5.transform.position);
        if (Distance < 50)
        {
            panda5.transform.position = espacio5.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            panda5Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            panda5.transform.position = panda5InitialPos;
            gamecontrol.Scorre += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    public void Droppanda6()
    {
        float Distance = Vector3.Distance(panda6.transform.position, espacio6.transform.position);
        if (Distance < 50)
        {
            panda6.transform.position = espacio6.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            panda6Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            panda6.transform.position = panda6InitialPos;
            gamecontrol.Scorre += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    
    

    private void Update()
    {
        if (panda1Correct && panda2Correct && panda3Correct && panda4Correct && panda5Correct && panda6Correct)
        {
            gameover.SetActive(true);
            reinicio.SetActive(true);
            volver.SetActive(true);
        }
    }

}
