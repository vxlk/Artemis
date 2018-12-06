using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerSetup : MonoBehaviourPunCallbacks {

   [SerializeField]
   Behaviour[] componentsToDisable;
    Camera sceneCamera;


    void Start()
    {
        if (!photonView.IsMine)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                //this.gameObject.tag = "Damagable";
                componentsToDisable[i].enabled = false;
            }
        }

        //else this.gameObject.tag = "Player";
    }
}
