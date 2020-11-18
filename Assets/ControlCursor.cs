using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCursor : MonoBehaviour
{
    public int tamañocursor = 50;
    public Texture2D cursormano, cursornormal;
    Texture2D cursorActivo;


    void Start()
    {
        Cursor.visible = false;
        CambiarCursor("normal");
    }
    public void CambiarCursor(string tipoCursor)
    {
        if (tipoCursor == "normal")
        {
            cursorActivo = cursornormal;
        }
        if (tipoCursor == "mano")
        {
            cursorActivo = cursormano;
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, tamañocursor, tamañocursor), cursorActivo);
    }
}
