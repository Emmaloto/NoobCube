
using UnityEngine;

public class ShopInfo : MonoBehaviour {
    public GameObject helpPanel;
    //public Canvas help;

    void OnGUI () {
		
	}

    void Start()
    {
        HidePanel();
    }

    public void ShowPanel()
    {
        helpPanel.SetActive(true);
        //help.enabled = true;
    }

    public void HidePanel()
    {
        helpPanel.SetActive(false);
        //help.enabled = false;
    }

}
