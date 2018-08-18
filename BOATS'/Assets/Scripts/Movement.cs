using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    public float moveSpeed=3.0f;
    private Rigidbody myBody;
    [SerializeField]
    private GameObject canonBall;
	void Start () {
        myBody=GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        myBody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, myBody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetKey("space")&&canonBall!=null)
        {
            moveSpeed = 3.0f;
            //parentcannonball
 
        }
        else
        {
            moveSpeed = 10.0f;
            //need a current movespeeed,maxspeed and slowspeed variable to avoid hardcoding

            if(canonBall!=null)
            {
                canonBall = null;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            canonBall = other.gameObject;
        }
    }

}
