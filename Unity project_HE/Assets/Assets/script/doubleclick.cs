using UnityEngine;
using System.Collections;

public class doubleclick : MonoBehaviour
{
    bool one_click = false;
    bool timer_running;
    float delay = 4;
    float timer_for_double_click;
    public GameObject first;
    public GameObject second;
    public GameObject explo;
    public float dist;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(0, 0.1f, 0));
        Vector3 pos = new Vector3(0, 0, 0);
        dist = Vector3.Distance(pos, gameObject.transform.position);

        if (dist >= 14)
        {
            blood.Instance.sub_blood();
        }

        if (dist >= 14)
        {
            Gamefunction.Instance.ReduceScore();
            Destroy(gameObject);
        }
        if (Time.timeScale == 0)
        {
            transform.Translate(new Vector3(0, -0.1f, 0));

        }
    }
    void OnMouseDown()
    {
        if (dist >= 3.63 && dist <= 5.3)
        {
            Gamefunction.Instance.AddScore();

        }
        if (dist >= 6.87 || dist <= 1.91)
        {
            Gamefunction.Instance.ReduceScore();
        }

        if (!one_click) // first click no previous clicks
        {
            one_click = true;
            timer_for_double_click = Time.time; // save the current time
                                                // do one click things;
        }
        else
        {
            one_click = false; // found a double click, now reset
            Destroy(gameObject);
            Instantiate(explo, transform.position, transform.rotation);
            if (tag == "Ball") //
            {
                Instantiate(explo, gameObject.transform.position, gameObject.transform.rotation);
            }

        }
        if (one_click)
        {

            Destroy(first);

            // if the time now is delay seconds more than when the first click started. 
            if ((Time.time - timer_for_double_click) > delay)
            {

                //basically if thats true its been too long and we want to reset so the next click is simply a single click and not a double click.

                one_click = false;

            }

        }

    }
}
