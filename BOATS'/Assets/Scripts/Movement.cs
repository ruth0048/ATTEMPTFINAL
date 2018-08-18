using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject grabPoint;
    private Rigidbody myBody;
    float moveSpeed = 3.0f;

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
                moveSpeed = moveSpeed * 0.5f;
                canonBall.transform.position = grabPoint.transform.position;
                canonBall.transform.parent = grabPoint.transform;
                hasBall = true;
            }
            else
            {
                moveSpeed = 3.0f;
                canonBall.transform.parent = null;
                canonBall = null;///////////////////////
                hasBall = false;
            }
        }
    }

    void RotatePlayer()
    {
        this.transform.forward = myBody.velocity;
        if (myBody.velocity.magnitude < 1.0f)
        {
            this.transform.forward = lastRotation;
        }
        lastRotation = transform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            canonBall = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ball")
        {
            if (hasBall == false)
            {
                canonBall.transform.parent = null;
                canonBall = null;
            }
        }
    }
}