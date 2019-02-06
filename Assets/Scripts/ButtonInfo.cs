using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour {

    
   
    [SerializeField] private int value;
    [SerializeField] public Text text;
    [SerializeField] public Text mainText;
    // Use this for initialization
    void Start () {
        value = Random.Range(0,49);
        text.text = "" + value;
    }
    private int MainButton() {
        
        return 0;
    }
	
}
