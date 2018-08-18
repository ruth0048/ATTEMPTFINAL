using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="boat")
        {
            Debug.LogWarning("WIN");
        }
    }
}
