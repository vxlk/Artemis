using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public string playerTag;
    public int damage;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == playerTag)
        {
            PlayerStats stats = col.gameObject.GetComponent<PlayerStats>();
            stats.Hit(damage);
        }
    }
}
