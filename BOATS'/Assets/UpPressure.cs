using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPressure : MonoBehaviour {

    private Rigidbody myRB;
    private float maxHeight;//=1.25f
    public float pressure=10.0f;

    //lowest point variable?
    //random up and down?
    //match waves

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody>();
        maxHeight = myRB.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (myRB.position.y < maxHeight)
        {
            Vector3 myVector = new Vector3(0.0f, pressure, 0.0f);
            myRB.AddForce(myVector, ForceMode.Force);
        }
        else
        { 
            Vector3 otherVec = new Vector3(myRB.position.x, maxHeight, myRB.position.z);
            myRB.MovePosition(otherVec);
        }
	}
}
