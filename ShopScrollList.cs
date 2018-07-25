using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Item {

    public string itemName;
    public Sprite icon;
    public int price = 1;
    public Material cubeSkin;
    public bool isOwned = false;
}

// This is the MAIN controller class for the shop
// Also contains menu elements, may move them to separate script soon
public class ShopScrollList : MonoBehaviour {

     
    public Transform contentPanel;
    public TextMeshProUGUI priceDisplay;
    public TextMeshProUGUI priceLabel;
    public TextMeshProUGUI myGold;
    public SimpleObjectPool buttonPool;
    public int cubePoints = 30;
    public GameObject cubePreview;
    private BoardController board;

    public GameObject buy;
    public GameObject use;
    public TextMeshProUGUI messageBoard;

    public bool loadFromMemory = false;
    public List<Item> itemList;
    private Item currSelected;

    // Use this for initialization
    void Start () {
        //  Just for testing
        // PlayerPrefs.SetInt("Cube Points", 150);

        cubePoints = PlayerPrefs.GetInt("Cube Points");
        board = messageBoard.GetComponentInParent<BoardController>();

        // Check for saved settings
        // Debug.Log(File.Exists(Application.persistentDataPath + "/playerInfo.dat"));
        //Debug.Log(Application.persistentDataPath + "/playerInfo.dat");
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat") && loadFromMemory)
        {
            itemList = GameController.control.LoadShopData(itemList);
        }

        AddButtons();
        if (itemList.Count != 0) {
            currSelected = itemList[0];
            ChangeCube(currSelected);
        }

        //RefreshItemList();



    }
	
    private void AddButtons()
    {
        for(int i = 0; i < itemList.Count; i++)
        {
            Item item = itemList[i];
            GameObject newButton = buttonPool.GetObject();
            newButton.transform.SetParent(contentPanel, false);

            ShopButton sampleButton = newButton.GetComponent<ShopButton>();
            sampleButton.Setup(item, this);
        }
    }

    public void ChangeCube(Item m)
    {
        currSelected = m;
        priceDisplay.text = m.price.ToString();

        Renderer rend = cubePreview.GetComponent<Renderer>();
        if (rend != null){
            rend.material = m.cubeSkin;
        }

        
        if (m.isOwned) {
            buy.SetActive(false);
            //buyButton.enabled = false;
            use.SetActive(true);
            priceDisplay.enabled = false;
            priceLabel.enabled = false;
            // Also remove the price label
        }
        else
        {
            buy.SetActive(true);
            use.SetActive(false);
            priceDisplay.enabled = true;
            priceLabel.enabled = true;
        }
        
    }

    public void BuySkin()
    {
        if(cubePoints > currSelected.price)
        {
            currSelected.isOwned = true;
            cubePoints = cubePoints - currSelected.price;
            PlayerPrefs.SetInt("Cube Points", cubePoints);
            myGold.text = PlayerPrefs.GetInt("Cube Points").ToString();

            ChangeCube(currSelected);
            messageBoard.text = "Sold!";
            //Debug.Log("Sold!");

            GameController.control.SaveShopData(itemList);
        }
        else
        {
            // Debug.Log("Not enough cube points. Sorry!");
            messageBoard.text = "Not enough cube points. Sorry!";

        }
        board.ShowBoard();


    }

    public void UseSkin()
    {
        GameController.control.skin = currSelected.cubeSkin;
        //Debug.Log("Skin applied successfully.");
        messageBoard.text = "Skin applied successfully.";

        board.ShowBoard();
    }




    // This takes the list stored in memory and replaces the list on the console
    // In case I want to view the saved settings
    private void RefreshItemList()
    {

    }

    public void GoBack()
    {
        SceneManager.LoadScene("Welcome");
    }

}
