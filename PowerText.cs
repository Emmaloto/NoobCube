using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 TO AVOID CONFUSION

    PowerText   -  The Power UI variables (the TextMeshProUGUI elements). This is set by a PowerUIItem.
    PowerUIItem -  The stored variables (strings and numbers)
     
     */
public class PowerText : MonoBehaviour {

    public TextMeshProUGUI label;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI quantity;
    public bool useTimer = false;

    public PowerList list;
    public PowerUIItem text;

    // Use this for initialization
    void Start () {
		
	}

    public void Setup(PowerUIItem textUI, PowerList scrollList)
    {
        
        text = textUI;

        label.text = text.labelName + ": ";
        label.name = text.labelName + " PowerUp ";
        timer.text = "00:" + text.time;
        quantity.text = text.powerNum + "";
        useTimer = text.useTime;


        if (useTimer)
            quantity.enabled = false;
        else
            timer.enabled = false;

        list = scrollList;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
