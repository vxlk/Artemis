using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScriptMultiplayer : MonoBehaviour {

    public int damage;
    //public ScoreKeeper skeep;
    public string isPlayer;
    void Start()
    {
        //skeep = GameObject.Find("_GM").GetComponent<ScoreKeeper>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == isPlayer)
        {
           // skeep.selectedGO = col.gameObject;
            //skeep.selected = true;
            PlayerStats stats = col.gameObject.GetComponent<PlayerStats>();
            Physics.IgnoreLayerCollision(8, 9, true);
            if (stats != null)
            {
                stats.Hit(damage);
            }
        }
    }
}
