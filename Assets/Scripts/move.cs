using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{   //Spitznamen für Rigidbody vergeben. Nicht vergessen die Komponente danach auf den Namen zu ziehen in Unity ;)
    public Rigidbody rig;
    public float bewegung = 2000f;
    public Transform spieler;
    public int hops = 1;
    public float sprung = 200f;
    public Transform respawn;

    public Transform joe;
   
 
  


   
    // FixedUpdate immer wenn es um Physik geht die wirken soll!
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rig.AddForce(0, 0, bewegung);
        }
        if (Input.GetKey("s"))
        {
            rig.AddForce(0, 0, -bewegung);
        }
        if (Input.GetKey("d"))
        {
            rig.AddForce(bewegung, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rig.AddForce(-bewegung, 0, 0);
        }
       
        
        
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(hops > 0)
            {
                rig.AddForce(0, sprung, 0);
                hops = hops - 1;
            }
            
        }
    }

    private void OnCollisionEnter(Collision boom)
    {
        if(boom.collider.name == "Boden")
        {
            hops = 2;
        }
        if(boom.collider.tag == "Gegner")
        {
            rig.freezeRotation = true;
            rig.AddForce(Vector3.Normalize(new Vector3(0, 0, spieler.position.z - boom.collider.transform.position.z)) * 5000);
        }
    }


}