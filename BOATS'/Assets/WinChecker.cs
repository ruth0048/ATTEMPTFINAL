using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour {
    public GameObject blackOut;
    //private bool win = false;
    private void Awake()
    {
        //FindObjectOfType<Camera>().Get
    }

    //private void Update()
    //{
    //    if(win)
    //    {
    //        fade();
    //    }
    //}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="boat")
        {
            //win = true;
            Debug.LogWarning("WIN");
        }
    }
}
