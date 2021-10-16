using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue3_Interaction : MonoBehaviour
{
    Color ElectroViolet = new Color(0.682f, 0.447f, 0.902f);

    Color LightBlue = new Color(0.361f, 0.529f, 0.639f);
    Color OriginalColor;
    // public GameObject wand;
    public bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        OriginalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Violet()
    {
        if (!activated)
        {
            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue3");
            foreach (GameObject obj in statue)
            {

                obj.GetComponent<Renderer>().material.color = ElectroViolet;

            }
            // wand.active = true;
            activated = true;

        }
    }



    public void ChangeColor()
    {
        if (!activated)
        {

            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue3");


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
