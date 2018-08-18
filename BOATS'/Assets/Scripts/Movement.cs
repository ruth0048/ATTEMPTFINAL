using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject grabPoint;
    private Rigidbody myBody;
    float moveSpeed = 2.0f;

    [SerializeField]
    private GameObject canonBall;
    private Vector3 lastRotation;
    bool hasBall = false;

    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        lastRotation = this.transform.forward;
    }

    void Update()
    {
        RotatePlayer();

        myBody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, myBody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetKeyDown("space") && canonBall != null)
        {
            if (hasBall == false)
            {
                moveSpeed = 1.5f;
                canonBall.transform.position = grabPoint.transform.position;
                canonBall.GetComponent<Rigidbody>().isKinematic = true;
                canonBall.transform.parent = grabPoint.transform;
                hasBall = true;
            }
            else
            {
                moveSpeed = 2.5f;
                canonBall.transform.parent = null;
                canonBall.GetComponent<Rigidbody>().isKinematic = false;
                canonBall.GetComponent<Rigidbody>().AddForce(new Vector3(this.transform.forward.x, this.transform.forward.y + 3.0f, this.transform.forward.z), ForceMode.Impulse);
                canonBall = null;
                hasBall = false;
            }
        }
    }

    void RotatePlayer()
    {
        //will force the player to look forward if not moving. 
        this.transform.forward = myBody.velocity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            if (hasBall == false)
            {
                canonBall = other.gameObject;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ball")
        {
            if (hasBall == false)
            {
                canonBall = null;
            }
        }
    }
}