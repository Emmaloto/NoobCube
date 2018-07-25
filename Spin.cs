using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    public float normalSpeed = 15f;
    public float hoverSpeed = 23f;
    //public Material selected;
    // public bool mouseHover;

    void Update()
    {
        //transform.Rotate(Vector3.up, speed * Time.deltaTime);
       // if(mouseHover)
        transform.Rotate(Vector3.up, normalSpeed * Time.deltaTime);
    }

    void OnMouseOver()
    {
        transform.Rotate(Vector3.up, hoverSpeed * Time.deltaTime);
    }

    /*
    void applyMaterial(Material m)
    {

    }
    */
}