using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {
    public Animator anim;
    private bool show;
    private float startTime;

	// This class is for animating the message board
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (show)
        {
            float time = System.DateTime.Now.Second - startTime;
            if(time >= 3)
            {
                HideBoard();
            }
        }
	}

    public void ShowBoard()
    {
        anim.SetTrigger("Show_msg");
        startTime = System.DateTime.Now.Second;
        show = true;
    }

    public void HideBoard()
    {
        anim.SetTrigger("Hide_msg");
        show = false;
    }
}
