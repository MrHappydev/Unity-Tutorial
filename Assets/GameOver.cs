using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Transform spieler;
    public Text over;

    private void Start()
    {
        over.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(spieler.position.y < 0)
        {
            over.enabled = true;
        }
    }
}
