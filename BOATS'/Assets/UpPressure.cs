using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPressure : MonoBehaviour {

    private Rigidbody myRB;
	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (myRB.position.y < 1.25f)
        {
            Vector3 myVector = new Vector3(0.0f, 10.0f, 0.0f);
            myRB.AddForce(myVector, ForceMode.Force);
        }
        else
        { 
            Vector3 otherVec = new Vector3(myRB.position.x, 1.25f, myRB.position.z);
            myRB.MovePosition(otherVec);
        }
	}
}
