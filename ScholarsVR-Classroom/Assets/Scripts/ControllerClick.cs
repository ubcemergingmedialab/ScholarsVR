using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControllerClick : MonoBehaviour
{

    public OVRInput.Controller right_controller;
    public OVRInput.Controller left_controller;
    bool right_press = false;
    bool left_press = false;
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OVRInput.FixedUpdate();

        right_press = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        left_press = OVRInput.Get(OVRInput.RawButton.LIndexTrigger);


        RaycastHit hit;

        if (Physics.Raycast(controller.transform.position, controller.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Prof"))
            {
                //if (right_press)
                    Debug.Log("Right Click on Prof");
            }
        }
    }
}