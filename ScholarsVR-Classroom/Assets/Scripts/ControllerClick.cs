using UnityEngine;

public class ControllerClick : MonoBehaviour
{

    public OVRInput.Controller right_controller;
    public OVRInput.Controller left_controller;
    bool right_press = false;
    bool left_press = false;
    public GameObject controller;
    bool click;

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
        click = (right_press || left_press);
        
        RaycastHit hit;

        if (Physics.Raycast(controller.transform.position, controller.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            HandleClick(hit, click);
        }
    }

    private void HandleClick(RaycastHit hit, bool click)
    {
        if (hit.collider.CompareTag("Raccoon"))
        {
            if (right_press)
            {
                Raccoon.PlayAudio();
                Raccoon.PauseOthers();
            }
        }
        if (hit.collider.CompareTag("TalkingStudent"))
        {
            if (right_press)
            {
                TalkingStudent.PlayAudio();
                TalkingStudent.PauseOthers();
            }
        }
        if (hit.collider.CompareTag("Pencil"))
        {
            if (right_press)
            {
                Pencil.PlayAudio();
                Pencil.PauseOthers();
            }
        }
        if (hit.collider.CompareTag("Eraser"))
        {
            if (right_press)
            {
                Eraser.PlayAudio();
                Eraser.PauseOthers();
            }
        }
    }
}