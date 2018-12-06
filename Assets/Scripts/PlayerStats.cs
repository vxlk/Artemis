using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    private static int winCondition;
    //keep track of score .. probably not a good idea to keep track of that on enemies when networking but yolo
    public static int enemiesDead;
    public int health;
    public bool isHit;

    public Canvas YouWinText;

    static PlayerStats()
    {
        enemiesDead = 0;
        winCondition = 1;
    }

    void Start()
    {
        YouWinText.gameObject.SetActive(false);
    }

    public int getHealth() { return health; }

    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Dead");
            ++enemiesDead;
            if (enemiesDead == winCondition)
            {
                YouWinText.gameObject.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }

    public void Hit(int damage)
    {
        isHit = true;
        health -= damage;
        isHit = false;
    }
}
