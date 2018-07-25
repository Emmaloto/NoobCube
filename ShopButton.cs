using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour {

    public Button button;
    public TextMeshProUGUI nameLabel;
    //public TextMeshProUGUI priceLabel;
    public Image iconImage;

    private Item item;
    private ShopScrollList scrollList;


	// Use this for initialization
	void Start () {
        button.onClick.AddListener(HandleClick);
	}

    // Sets up buttons in shop
    public void Setup(Item currItem, ShopScrollList currList)
    {
        item = currItem;
        nameLabel.text = item.itemName;
        //priceLabel.text = item.price.ToString();
        iconImage.sprite = item.icon;

        scrollList = currList;
    }

    public void HandleClick()
    {
        //scrollList.TryTransferItemToOtherShop(item);
        scrollList.ChangeCube(item);
    }

}
