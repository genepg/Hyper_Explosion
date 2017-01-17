using UnityEngine;
using System.Collections;

public class gamelong : MonoBehaviour
{

    public GameObject longball;
    public double time = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time = time + Time.deltaTime;
        Vector3 pos = new Vector3(0, 0, 0);
        if ((time >= 2.34) && (time <= 2.34 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 59.50) && (time <= 59.50 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 73.54) && (time <= 73.54 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 81.00) && (time <= 81.00 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 81.26) && (time <= 81.26 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 81.52) && (time <= 81.52 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 87.46) && (time <= 87.46 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 88.20) && (time <= 88.20 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 88.46) && (time <= 88.46 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 98.10) && (time <= 98.10 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 98.36) && (time <= 98.36 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
        if ((time >= 99.02) && (time <= 99.02 + 0.025))
        {
            Instantiate(longball, pos, transform.rotation);
        }
    }
}
