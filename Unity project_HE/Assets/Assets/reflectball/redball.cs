using UnityEngine;
using System.Collections;

public class redball : MonoBehaviour
{
    public float dist;
    public int D = 0;
    public double current_time = 0.0;
    public double time = 0.0;
    bool one_click = true;
    public GameObject first;
    public GameObject second;
    // Use this for initialization
    void Start()
    {
        D = Gamefunction.Instance.degree();
    }



    // Update is called once per frame
    void Update()
    {
        current_time = Time.time;
        Vector3 pos = new Vector3(0, 0, 0);
        dist = Vector3.Distance(pos, gameObject.transform.position);
        //gameObject.transform.position += new Vector3(-0.1f,0,0);
        transform.Translate(new Vector3(0, 0.1f, 0));


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
        if (dist >= 1 && dist <= 10)
        {
            if (one_click)
            {
                time = current_time;
                Destroy(first);
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180 + D);

                //gameObject.GetComponent<Image> ().sprite = first;

                one_click = false;


            }
            else if (one_click == false && current_time >= (time + 1))
            {
                Destroy(gameObject);
            }
        }

    }



}

