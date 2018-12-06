using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowScript : MonoBehaviour {

    float _charge;

    public float chargeMax;
    public float chargeRate;
    public Transform orientRef;
 

    public KeyCode firebutton;

    public Transform spawn;
    public Rigidbody arrowObj;


    void Update()
    {
        if(Input.GetKey(firebutton) && _charge < chargeMax)
        {
            _charge += Time.deltaTime * chargeRate;
            Debug.Log(_charge.ToString());
        }

        if(Input.GetKeyUp(firebutton))
        {
            Rigidbody arrow = Instantiate(arrowObj, transform.position, transform.rotation) as Rigidbody;
            arrow.transform.LookAt(orientRef);          
            arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);

            _charge = 0;
        }
    }
}
