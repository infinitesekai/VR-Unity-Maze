using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInteraction : MonoBehaviour
{
    public float degreePerSecond;
    private int RotateDirection = 1;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateDirection * degreePerSecond * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider collider)
    {

        coin.active = false;



    }

}
