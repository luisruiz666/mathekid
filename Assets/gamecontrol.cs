using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class gamecontrol : MonoBehaviour
{
    public static int Scorre = 0;
    public string ScoreString = "FALLAS";

    public Text TextScorre;
    public static gamecontrol Gamecontrolerr;

    
    void Awake()
    {
       
        Gamecontrolerr = this;
    }


    void Update()

    {
        if (TextScorre != null)
        {
            TextScorre.text = ScoreString + Scorre.ToString();
            

        }


        
    }

   
}