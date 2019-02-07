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
    bool permission=false;
    static Text mainButton;//Ulaşmak istediğimiz sayı
    string calculation = "";
    double sum = 0;
    
    private string mainString="";

    public void Randomize()
    {
      
    }
    public void ButtonPressed()
    {
        //buttons[Int32.Parse(EventSystem.current.currentSelectedGameObject.tag) - 1].text
        if (EventSystem.current.currentSelectedGameObject.name == "+" || EventSystem.current.currentSelectedGameObject.name == "-" || EventSystem.current.currentSelectedGameObject.name == "x" || EventSystem.current.currentSelectedGameObject.name == "div")
        {
           // Debug.Log("hey");
            if (permission)
            {
                if(EventSystem.current.currentSelectedGameObject.name != "div")
                    mainString += " " + EventSystem.current.currentSelectedGameObject.tag;
                else
                    mainString += " /";

                permission = false;
            }
            else {
                Debug.Log("choose a number first");
            }
        }
        else
        {
            if (!permission)
            {
                mainString += " " + buttons[Int32.Parse(EventSystem.current.currentSelectedGameObject.tag)-1].text;
                permission = true;
            }
            

        }
        Calculate();
        Debug.Log(mainString);

    }
    public void Calculate()
    {
        mainString=mainString.Trim();
       string [] array = mainString.Split(' ');
        if (array.Length==3){
            mainString = "";
            switch (array[1])
            {
                case "+":mainString=""+(Int32.Parse(array[0]) + Int32.Parse(array[2]));
                    break;
                case "-":
                    mainString = "" + (Int32.Parse(array[0]) - Int32.Parse(array[2]));
                    break;
                case "*":
                    mainString = "" + (Int32.Parse(array[0]) * Int32.Parse(array[2]));
                    break;

                case "/":
                    mainString = "" + (Int32.Parse(array[0]) /Int32.Parse(array[2]));
                    break;

            }
        }
    }
   
}
