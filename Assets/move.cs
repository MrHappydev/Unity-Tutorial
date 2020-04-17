using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{   //Spitznamen für Rigidbody vergeben. Nicht vergessen die Komponente danach auf den Namen zu ziehen in Unity ;)
    public Rigidbody rig;
    public float bewegung = 2000f;
    //Das f nach der Zahl angewöhnen. Waschbären sind geil!

    // FixedUpdate immer wenn es um Physik geht die wirken soll!
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rig.AddForce(0, 0, bewegung * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rig.AddForce(0, 0, -bewegung * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rig.AddForce(bewegung * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rig.AddForce(-bewegung * Time.deltaTime, 0, 0);
        }
    }
}