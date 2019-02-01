using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUp : MonoBehaviour {

    // public GameObject pickupEffect;
    //public string powerType;

    //public TextMeshProUGUI jumpNo;

    //public bool activated = false;
    //Collider play;

    public PlayerMovement playerInfo;
    public GameManager manager;
    //public PlayerMovementNoMat playerInfo;
    public int IDNumber;
    public string powerName;
    public bool powerPrinted = false;

    //public Transform powerPanel;
    public PowerList powerInfo;

    private void Start()
    {
        //powerInfo = powerPanel.GetComponent<PowerList>();
    }

    private void Update()
    {

    }

    // If I call the powerUp class with an ID. The main reason this exists
    // is if I decide not to use the parent object this component has to call this class (for some reason)
    public void SetReaction(int identifier, string pName)
    {
        powerInfo.printPowers();

        // Checks the list of listed powers to see if this power label already exists
        PowerUIItem preExisting = new PowerUIItem();
        for (int i = 0; i < powerInfo.textList.Count; i++)
        {
            if(powerInfo.textList[i].labelName == pName)
            {
                powerPrinted = true;
                preExisting = powerInfo.textList[i];
            }
            //else { }
        }


        switch (identifier) {
            // We re-use the power label if the name has already been activated
            // If not we create it
            case 0:
                if (!powerPrinted)
                {
                    PowerUIItem jump = new PowerUIItem(pName, 1, 0, false);
                    powerInfo.AddItem(jump);
                    
                }
                else
                {
                    //powerInfo.RemoveItem(preExisting);
                    
                    preExisting.powerNum = preExisting.powerNum + 1;
                    
                    //powerInfo.AddItem(preExisting);
                    Debug.Log(preExisting.labelName + " exists, now qty = " + preExisting.powerNum);

                    Debug.Log("Number in list: " + powerInfo.textList.Count);

                    
                }
                powerInfo.RefreshDisplay();
                manager.jumpsGotten++;
                break;

            case 1:
                if (!powerPrinted)
                {
                    PowerUIItem fire = new PowerUIItem(pName, 1, 0, false);
                    powerInfo.AddItem(fire);

                }
                else
                {
                    //powerInfo.RemoveItem(preExisting);
                    preExisting.powerNum = preExisting.powerNum + 1;
                    //powerInfo.AddItem(preExisting);
                    Debug.Log("Pre-existing label:  " + preExisting.labelName);
                    Debug.Log(preExisting.labelName + " exists, now qty = " + preExisting.powerNum);
                    Debug.Log("Number in list: " + powerInfo.textList.Count);
                    powerInfo.RefreshDisplay();
                }
                break;

            case 2:

                break;

        }
        Debug.Log("After adding: ");
        powerInfo.printPowers();
    }
    /*
            case 0: - Jump

            case 1: - Money

            case 2: - WoodChipper

         
         */

    // If I call the powerUp class without giving an ID, use the one in the class
    public void SetReaction()
    {
        SetReaction(IDNumber, powerName);
    }

}
