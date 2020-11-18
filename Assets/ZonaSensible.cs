using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaSensible : MonoBehaviour
{
    public ControlCursor controlCursor;


    void OnMouseEnter()
    {
        controlCursor.CambiarCursor("mano");  
    }
     void OnMouseExit()
    {
        controlCursor.CambiarCursor("normal");
            
    }
}
