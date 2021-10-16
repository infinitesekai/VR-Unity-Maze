using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrisInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    Color OriginalColor;
    Color LightGrey = new Color(0.596f, 0.58f, 0.58f);
    public float degreePerSecond;
    private int RotateDirection = 1;

    void Start()
    {
        OriginalColor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateDirection * degreePerSecond * Time.deltaTime, 0);
    }


    public void Teleport()
    {
        Vector3 newPos;

        newPos = new Vector3(Random.Range(-2f,2f), Random.Range(0.5f, 2f), Random.Range(-2f, 2f));
        transform.position = newPos;

    }

    public void ChangeDirection()
    {
        RotateDirection = -1;//opposite direction
        degreePerSecond = degreePerSecond * 2;
        GetComponent<Renderer>().material.color = LightGrey;

    }

    public void RevertDirection()
    {
        RotateDirection = 1;//original direction
        degreePerSecond = degreePerSecond / 2;
        GetComponent<Renderer>().material.color = OriginalColor;
    }
}
