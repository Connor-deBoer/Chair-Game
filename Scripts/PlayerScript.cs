using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerScript : MonoBehaviour
{
    public Transform directionForward;
    bool buttonCheckForward = false;
    public float speed = 20;
    public XRController right;
    Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //buttonCheckForward = false;
        //InputHelpers.IsPressed(right.inputDevice, InputHelpers.Button.PrimaryButton, out buttonCheckForward);

        /*if (buttonCheckForward)
        {
            speed = 20;
        }
        else
        {
            speed = 0;
        }*/
        playerRb.AddForce(directionForward.forward * speed * Time.deltaTime);
        //Debug.Log(buttonCheckForward);
    }
}
