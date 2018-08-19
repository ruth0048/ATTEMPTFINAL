using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour {
    public GameObject win;
    private AudioManager myAudio;
    //private bool win = false;
    private void Awake()
    {
        myAudio = FindObjectOfType<AudioManager>();
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
            myAudio.Stop("Music");
            myAudio.Play("Win");
            win.gameObject.GetComponent<GameMenuManager>().onWin();
            Debug.LogWarning("WIN");
        }
    }
}
