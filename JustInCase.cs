using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustInCase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    /*
     * 
     * 
     *     // Save Item list to style so that 
    private void SaveList()
    {
        bool[] itemValues = new bool[itemList.Count];

        for(int i = 0; i < itemValues.Length; i++)
        {
            itemValues[i] = itemList[i].isOwned;
        }

        //GameController.control.SaveShopData(itemList);

        GameController.control.SaveShopData(itemValues);
    }

    private void LoadList()
    {
        using (Stream stream = File.Open("save.dat", FileMode.Open))
        {
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            itemList = (List<Item>)bformatter.Deserialize(stream);
        }
    }

    private void RemoveButtons()
    {
        while (contentPanel.childCount > 0)
        {
            GameObject toRemove = transform.GetChild(0).gameObject;
            buttonPool.ReturnObject(toRemove);
        }
    }

    private void RefreshDisplay()
    {
        //myGold.text = "Gold: " + gold.ToString();
        RemoveButtons();
        AddButtons();
    }
    
    public void TryTransferItemToOtherShop(Item item)
    {
        
        if (otherShop.gold >= item.price) {
            gold += item.price;
            otherShop.gold -= item.price;
            AddItem(item, otherShop);
            RemoveItem(item, this);

            RefreshDisplay();
            otherShop.RefreshDisplay();
        }
        
    }
    
    private void AddItem(Item itemToAdd, ShopScrollList shopList)
    {
        shopList.itemList.Add(itemToAdd);

    }

    private void RemoveItem(Item itemToRemove, ShopScrollList shopList)
    {
        for(int i = shopList.itemList.Count - 1; i >= 0; i--)
        {
            if (shopList.itemList[i] == itemToRemove)
                shopList.itemList.RemoveAt(i);
        }

    }
*/

}
