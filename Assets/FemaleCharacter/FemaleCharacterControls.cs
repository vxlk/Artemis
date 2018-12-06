using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleCharacterControls : MonoBehaviour
{

    static Animator anim;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.ResetTrigger("Skate");
            anim.SetTrigger("drawBow");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            anim.ResetTrigger("drawBow");
            anim.SetTrigger("Skate");
        }
    }
}

