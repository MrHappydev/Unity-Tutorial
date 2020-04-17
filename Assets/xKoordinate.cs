using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xKoordinate : MonoBehaviour
{

    public Transform spieler;
    public Text punkte;

    // Update is called once per frame
    void Update()
    {
        punkte.text = spieler.position.x.ToString("0");
    }
}
