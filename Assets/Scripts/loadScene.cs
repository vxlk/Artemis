using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

    //when button is pressed, load a scene specified by an index in the build settings
	public void loadSceneOnClick(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
