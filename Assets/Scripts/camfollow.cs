using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{   // Transform beinhaltet position, rotation und scale. Siehe unten =)
    public Transform spieler;
    public Vector3 abstand;

    // Ich frage mich, warum ständig der Pudding aus ist...
    void FixedUpdate()
    {
        transform.position = spieler.position + abstand;
        // transform klein geschrieben = immer auf das Objekt bezogen wo das Script liegt
        // Wahlweise hier auch transform.rotation = spieler.rotation wenn man zB ein Autospiel macht in dem sich das Auto überschlägt
    }
}