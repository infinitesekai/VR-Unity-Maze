using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneInteraction : MonoBehaviour
{
    Color OriginalColor;
    Color LightGrey = new Color(0.596f, 0.58f, 0.58f);
    public GameObject stone;

    // Start is called before the first frame update
    void Start()
    {

        OriginalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColor()
    {

        GetComponent<Renderer>().material.color = LightGrey;


    }

    public void RevertColor()
    {

        GetComponent<Renderer>().material.color = OriginalColor;
    }

    public void ClickStone()
    {
        stone.active = false;
    }
}
