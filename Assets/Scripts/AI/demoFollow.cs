using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoFollow : MonoBehaviour {
    public Transform hitBox;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

        //have the model look at the player, so it looks nicer, but dont do it for the hoverboard
        if (gameObject.tag != "Finish")
        {
            Component c = GameObject.FindGameObjectWithTag("Player").transform;
            gameObject.transform.LookAt(c.transform, new Vector3(0, 1, 0));
        }

        gameObject.transform.position = hitBox.transform.position;
        
    }
}
