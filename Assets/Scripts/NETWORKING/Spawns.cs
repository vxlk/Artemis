using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour {
    public GameObject spawnPoint;
	// Use this for initialization
	void Start () {
        spawnPoint = GameObject.FindGameObjectWithTag("Spawn1");
        if (spawnPoint)
            transform.TransformPoint(spawnPoint.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
