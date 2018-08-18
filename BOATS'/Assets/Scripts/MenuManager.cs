using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject playButton;
    public GameObject exitButton;
    public GameObject creditsButton;
    public GameObject controlsButton;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPlayButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExitButton()
    {
        Application.Quit();
    }

    public void OnCreditsButton()
    {
        
    }

    public void OnControlsButton()
    {

    }
}
