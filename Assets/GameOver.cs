using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ↑ wird benötigt damit public Text angesprochen werden kann

public class GameOver : MonoBehaviour
{
    public Transform spieler;
    public Text over;

    // warum schnüffelst du eigentlich in meinen Scripts?
    private void Start()
    {
        over.enabled = false;
        // Am Anfang inaktiv. Deshalb over.enabled = false;
        //over.disbaled = true gibt's nicht!!!
    }

    // Update is called once per frame
    void Update()
    { // IF IST KEINE SCHLEIFE!!!!
        if(spieler.position.y < 0)
        {
            over.enabled = true;
        }
    }
}
