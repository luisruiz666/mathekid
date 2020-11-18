using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;


public class manager2 : MonoBehaviour
{
    public GameObject mexicano1, mexicano2, mexicano3,finta1,finta2,base1, base2, base3;
    public GameObject gameover;
    public GameObject reinicio;
    public GameObject volver;
    public GameObject caranormal;
    public GameObject carafeliz;
    public GameObject caratriste;
    public GameObject carapensar;
    public int puntaje = 1;
    

    Vector2 mexicano1InitialPos, mexicano2InitialPos, mexicano3InitialPos,finta1InitialPos,finta2InitialPos;

    public AudioSource source;
    
    public AudioClip[] correct;
    public AudioClip incorrect;

    bool mexicano1Correct, mexicano2Correct, mexicano3Correct = false;

    private void Start()
    {
        caranormal.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        carapensar.SetActive(false);
        gameover.SetActive(false);
        reinicio.SetActive(false);
        volver.SetActive(false);

        mexicano1InitialPos = mexicano1.transform.position;
        mexicano2InitialPos = mexicano2.transform.position;
        mexicano3InitialPos = mexicano3.transform.position;
        finta1InitialPos = finta1.transform.position;
        finta2InitialPos = finta2.transform.position;
       
    }

    public void Dragmexicano1()
    {
        mexicano1.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);
    }
    public void Dragmexicano2()
    {
        mexicano2.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);

    }
    public void Dragmexicano3()
    {
        mexicano3.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);
    }
    public void Dragfinta1()
    {
        finta1.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);
    }
    public void Dragfinta2()
    {
        finta2.transform.position = Input.mousePosition;
        carapensar.SetActive(true);
        carafeliz.SetActive(false);
        caratriste.SetActive(false);
        caranormal.SetActive(false);
    }

    public void Dropmexicano1()
    {
        float Distance = Vector3.Distance(mexicano1.transform.position, base1.transform.position);
        if (Distance < 50)
        {
            mexicano1.transform.position = base1.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            mexicano1Correct = true;
            carafeliz.SetActive(true);
           

        }
        else
        {
            mexicano1.transform.position = mexicano1InitialPos;
            GameControler.Score += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
           

        }
    }
    public void Dropmexicano2()
    {
        float Distance = Vector3.Distance(mexicano2.transform.position, base2.transform.position);
        if (Distance < 50)
        {
            mexicano2.transform.position = base2.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            mexicano2Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            mexicano2.transform.position = mexicano2InitialPos;
            GameControler.Score += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }
    }
    public void Dropmexicano3()
    {
        float Distance = Vector3.Distance(mexicano3.transform.position, base3.transform.position);
        if (Distance < 50)
        {
            mexicano3.transform.position = base3.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            mexicano3Correct = true;
            carafeliz.SetActive(true);
        }
        else
        {
            mexicano3.transform.position = mexicano3InitialPos;
            GameControler.Score += puntaje;
            source.clip = incorrect;
            source.Play();
            caratriste.SetActive(true);
        }

       
    }

    public void Dropfinta1()
    {
       
        
      finta1.transform.position = finta1InitialPos;
      GameControler.Score += puntaje;
      source.clip = incorrect;
      source.Play();
        caratriste.SetActive(true);



    }
    public void Dropfinta2()
    {


        finta2.transform.position = finta2InitialPos;
        GameControler.Score += puntaje;
        source.clip = incorrect;
        source.Play();
        caratriste.SetActive(true);



    }

    private void Update()
    {
        if (mexicano1Correct && mexicano2Correct && mexicano3Correct)
        {
            gameover.SetActive(true);
            reinicio.SetActive(true);
            volver.SetActive(true);
        }
    }



}
