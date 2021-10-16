using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue2_Interaction : MonoBehaviour
{

    Color GeoYellow = new Color(0.886f, 0.671f, 0.114f);

    Color LightBlue = new Color(0.361f, 0.529f, 0.639f);
    Color OriginalColor;
    bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        OriginalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Yellow()
    {
        if (!activated)
        {
            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue2");
            foreach (GameObject obj in statue)
            {

                obj.GetComponent<Renderer>().material.color = GeoYellow;

            }
            activated = true;

        }
    }



    public void ChangeColor()
    {
        if (!activated)
        {

            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue2");


            foreach (GameObject obj in statue)
            {

                obj.GetComponent<Renderer>().material.color = LightBlue;

            }

        }




    }

    public void RevertColor()
    {

        if (!activated)
        {


            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue2");


            foreach (GameObject obj in statue)
            {

                obj.GetComponent<Renderer>().material.color = OriginalColor;

            }

        }
    }
}
