using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControllerClick : MonoBehaviour
{

    public OVRInput.Controller right_controller; 
    public OVRInput.Controller left_controller;
    Vector3 right_controller_position;
    Vector3 left_controller_position;
    bool right_press = false;
    bool left_press = false;

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

        right_controller_position = OVRInput.GetLocalControllerPosition(right_controller);
        left_controller_position = OVRInput.GetLocalControllerPosition(left_controller);

        RaycastHit hit;

        if (Physics.Raycast(right_controller_position, right_controller_position + Vector3.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Prof"))
            {
                // if (right_press)
                    Debug.Log("Right Click on Prof");
            }
        }
        
        /*
        if (right_press)
        {
            RightClickHandler();
        }

        if (left_press)
        {
            LeftClickHandler();
        }
        */
    }

    void RightClickHandler()
    {
        right_press = false;
        Debug.Log("Right Press");
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Prof"))
            {
                
                Debug.Log("Right Click on Prof");
            }
        }
    }

    void LeftClickHandler()
    {
        left_press = false;
        Debug.Log("LeftPress");
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Prof"))
            {
                Debug.Log("Left Click on Prof");
            }
        }
    }
}
