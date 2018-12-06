using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtonHandler : MonoBehaviour {

    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;
    public Canvas mainMenuCanvas;
    public TGIManager ti;

    // Use this for initialization
    void Start ()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(continueClicked);
        m_YourSecondButton.onClick.AddListener(twitchIntegrationClicked);
        m_YourThirdButton.onClick.AddListener(quitClicked);
    }

    void continueClicked()
    {
        //close the menu
        mainMenuCanvas.gameObject.SetActive(false);
    }

    void twitchIntegrationClicked()
    {
        ti.setTGIActive();
    }

    void quitClicked()
    {
        //close the app
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        if (Input.GetKeyDown(KeyCode.Alpha1))
            continueClicked();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            twitchIntegrationClicked();
        if (Input.GetKeyDown(KeyCode.Alpha3))
            quitClicked();
    }
}
