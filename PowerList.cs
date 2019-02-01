using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PowerUIItem
{
    public string labelName;
    public int powerNum;
    public int time;
    public bool useTime;

    public PowerUIItem(string lab, int pNo, int t, bool use)
    {
        labelName = lab;
        powerNum = pNo;
        time = t;
        useTime = use;
    }

    public PowerUIItem()
    {
        labelName = "";
        powerNum = 0;
        time = 0;
        useTime = false;
    }
}



public class PowerList : MonoBehaviour {
    public List<PowerUIItem> textList;
    public Transform panel;
    public SimpleObjectPool objPool;

    public GameObject prefab;

    private void AddText()
    {
        for (int i = 0; i < textList.Count; i++)
        {
            PowerUIItem item = textList[i];
            GameObject newText = objPool.GetObject();

            //Debug.Log("Pool = null: " + objPool == null);
            //Debug.Log("GameObj = null: " + newText == null);

            //GameObject newText = (GameObject)GameObject.Instantiate(prefab);
            newText.transform.SetParent(panel, false);
            
            PowerText sampleText = newText.GetComponent<PowerText>();
            sampleText.Setup(item, this);

            //Debug.Log("Text added: " + sampleText.label.text + " - " + sampleText.quantity.text);
        }
    }

    private void RemoveText()
    {
        while (panel.childCount > 0)
        {
            GameObject toRemove = transform.GetChild(0).gameObject;
            objPool.ReturnObject(toRemove);
            //Destroy(toRemove);
            
        }

        
    }


    public void AddItem(PowerUIItem itemToAdd)
    {
        textList.Add(itemToAdd);
        //Debug.Log("Adding Item...");
        RefreshDisplay();


    }

    
    public void RemoveItem(PowerUIItem itemToRemove)
    {
        for (int i = textList.Count - 1; i >= 0; i--)
        {
            if (textList[i] == itemToRemove)
            {
                textList.RemoveAt(i);
            }
        }

        RefreshDisplay();
    }

    // Use this for initialization
    void Start () {
        //RefreshDisplay();
        AddText();
    }

    public void RefreshDisplay()
    {
        //AddText();
        RemoveText();
        AddText();
        //Debug.Log("Refreshing...");

    }

    public void printPowers()
    {
        for (int i = 0; i < textList.Count; i++)
        {
            PowerUIItem item = textList[i];
            Debug.Log(i + ":" + item.labelName);
            Debug.Log("Is displaying? " + item.labelName);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
