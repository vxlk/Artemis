using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public Canvas mainMenuCanvas;
	// Use this for initialization
	void Start () {
        //don't show on startup
        mainMenuCanvas.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        bool isOn = mainMenuCanvas.gameObject.activeSelf;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenuCanvas.gameObject.SetActive(!isOn); //do the opposite of the current state
        }
	}
}
