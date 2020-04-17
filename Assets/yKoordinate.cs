using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yKoordinate : MonoBehaviour
{
    public Transform spieler;
    public Text punkte;

    // Update is called once per frame
    void Update()
    {
        punkte.text = spieler.position.y.ToString("0");
    }
}
