using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int WalkSpeed;
    public bool OnWalk = true;
    public float AngleToStartWalk = 30.0f;//walk when camera turn 30 drgree
    Transform cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cam = GetComponentInChildren<Camera>().transform;
        if (cam.eulerAngles.x > AngleToStartWalk && cam.eulerAngles.x < 90.0f) //90 degree change direction
        {
            transform.position = transform.position + Camera.main.transform.forward * WalkSpeed * Time.deltaTime;
        }
    }


    public void WalkFnOn()
    {
        OnWalk = true;
    }

    public void WalkFnOff()
    {
        OnWalk = false;
    }
}
