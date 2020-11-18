using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class GameControler : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "FALLAS";

    public Text TextScore;
    public static GameControler Gamecontroller;

    void Awake()
    {
        Gamecontroller = this;
    }
   
    void Update()
    {
        if (TextScore!=null)
        {
            TextScore.text = ScoreString + Score.ToString();
        }
    }
}
