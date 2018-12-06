using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAIMovement : MonoBehaviour {
    public NavMeshAgent nav;
    public Transform player;
    public PlayerStats health;
    private int currentHealth;
    //private Vector3 ghettoYfix;

	// Use this for initialization
	void Start () {
        // Set up the references.
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        //gameObject.transform.position += ghettoYfix;
       // ghettoYfix = new Vector3(0, 3, 0);
        gameObject.tag = "Damagable";
        currentHealth = health.getHealth();
        nav = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (currentHealth > 0)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            nav.SetDestination(player.position);
            //player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
