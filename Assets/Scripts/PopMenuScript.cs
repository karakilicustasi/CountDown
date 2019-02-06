using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopMenuScript : MonoBehaviour {
    static GameObject plus;
    static GameObject minus;
    static GameObject multiply;
    static GameObject divide;
    public int clicked =1;
    private void Start()
    {
        plus=GameObject.Find("+");
        minus = GameObject.Find("-");
        multiply = GameObject.Find("x");
        divide = GameObject.Find("div");
        Dissappear();
    }
    public void Dissappear()
    {
        plus.SetActive(false);//deactivates the gameobject
        minus.SetActive(false);
        multiply.SetActive(false);
        divide.SetActive(false);
    }
    public void Appear()
    {
        clicked++;
        //bir milyon kere tıklayıp hekleme fikri burdan çıktı :)
        //If its clicked even times it appears.
        if (clicked % 2 == 0)
        {
            
            plus.SetActive(true);
            minus.SetActive(true);
            multiply.SetActive(true);
            divide.SetActive(true);
        }
        else
        {
            Dissappear();
            
        }
        
     
    }
}
