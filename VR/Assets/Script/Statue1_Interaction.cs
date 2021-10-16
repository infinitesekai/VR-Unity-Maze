using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue1_Interaction : MonoBehaviour
{
    Color MintGreen = new Color(0.325f, 0.675f, 0.6f);

    Color LightBlue = new Color(0.361f, 0.529f, 0.639f);
    Color OriginalColor;
    bool activated = false;
    public PlayerWalk player;
    // Start is called before the first frame update
    void Start()
    {
        OriginalColor = GetComponent<Renderer>().material.color;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Green()
    {
        if (!activated)
        {
            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue1");
            foreach (GameObject obj in statue)
            {

                obj.GetComponent<Renderer>().material.color = MintGreen;


            }

            player.WalkSpeed = player.WalkSpeed * 2;

            activated = true;

        }
    }



    public void ChangeColor()
    {
        if (!activated)
        {

            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue1");


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


            GameObject[] statue = GameObject.FindGameObjectsWithTag("Statue1");


            foreach (GameObject obj in statue)
            {

                obj.GetComponent<Renderer>().material.color = OriginalColor;

            }

        }
    }
}
