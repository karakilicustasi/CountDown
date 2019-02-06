using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Game : MonoBehaviour {
    static Text button1;
    static Text button2;
    static Text button3;
    static Text button4;
    static Text button5;
    static Text button6;
    public Text[] buttons= { button1, button2, button3, button4, button5, button6};
    Boolean permission=true;
    Text mainButton;//Ulaşmak istediğimiz sayı
    
    private string mainString="";

    public void Randomize()
    {
      
    }
    public void ButtonPressed()
    {
        Debug.Log(buttons[Int32.Parse(EventSystem.current.currentSelectedGameObject.tag)-1].text);

    }
    public void Calculate()
    {
     
    }
}
