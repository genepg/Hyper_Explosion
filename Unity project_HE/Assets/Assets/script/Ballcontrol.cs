using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class Ballcontrol : MonoBehaviour
{
    public GameObject explo;
    public float dist;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(0, 0, 0);
        transform.Translate(new Vector3(0, 0.1f, 0));
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
        Destroy(gameObject);
        if (dist >= 3.63 && dist <= 5.3)
        {
            Gamefunction.Instance.AddScore();

        }
        if (dist >= 6.87 || dist <= 1.91)
        {
            Gamefunction.Instance.ReduceScore();
        }

        Instantiate(explo, transform.position, transform.rotation);
        if (tag == "Ball") //
        {
            Instantiate(explo, gameObject.transform.position, gameObject.transform.rotation);
        }




    }



}

