using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class CameraO : MonoBehaviour
{
    public TextAlignment text;
    GUIStyle smallFont;
    GUIStyle largeFont;
    Camera camera;
    PlayerCCC playerccc;
    string str;
    void Start()
    {
        GUI.color = Color.blue;
        smallFont = new GUIStyle();
        largeFont = new GUIStyle();

        smallFont.fontSize = 100;
        largeFont.fontSize = 120;
        camera = GetComponent<Camera>();
        playerccc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCCC>();                   
    }
    void Update()
    {
        str = Convert.ToString(playerccc.coins);
    }
    void OnGUI() 
    {
        int size = 20;
        float x = camera.pixelWidth / 10 - size / 4;
        float y = camera.pixelHeight / 10 - size / 3;
        
        GUIStyle numberColor = new GUIStyle();
        numberColor.normal.textColor = Color.yellow;
        numberColor.fontSize = 80;
        GUI.Label(new Rect(x, y, size, size), str + "/10", numberColor);
        
        if (playerccc.coins >= 10)
        {
                
             x = camera.pixelWidth / 5 - size / 4;
             y = camera.pixelHeight / 2 - size / 3;
            GUIStyle yellow = new GUIStyle();
            yellow.normal.textColor = Color.yellow;
            yellow.fontSize = 100;
            GUI.Label(new Rect(x, y, size, size), "CONGRATULATIONS\n" +
                "Вы выиграли!!!", yellow);

        }
    }
}
