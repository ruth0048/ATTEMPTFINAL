using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {

    public CannonBallsFall ball;

	void Update ()
    {
		if(this.transform.position.y < -50)
        {
            ball.cannonBalls.DeactivateObject(this.gameObject);
        }
	}
}
