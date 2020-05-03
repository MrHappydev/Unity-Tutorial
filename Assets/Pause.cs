using UnityEngine;

public class Pause : MonoBehaviour
{
    public Canvas pause;

    private void Start()
    {
        pause.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("escape") && pause.enabled)
        {
            pause.enabled = false;
            Time.timeScale = 1;
        }

        else if (Input.GetKeyDown("escape") && !pause.enabled)
        {
            pause.enabled = true;
            Time.timeScale = 0;
        }
    }
}
