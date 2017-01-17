using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour
{

    public GameObject BackBot;
    private bool paused = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        if (paused)
        {

            BackBot.SetActive(true);

        }
        if (!paused)
        {

            BackBot.SetActive(false);

        }
    }
}
