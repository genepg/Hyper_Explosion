using UnityEngine;
using System.Collections;

public class longballcontrol : MonoBehaviour
{
    public GameObject explo;
    public float dist;
    public int De;
    /*public double currenttime = 0.0;*/
    public double time = 0;
    // Use this for initialization
    void Start()
    {
        De = Gamefunction.Instance.degree();

    }

    // Update is called once per frame
    void Update()
    {



        Vector3 pos = new Vector3(0, 0, 0);
        gameObject.transform.position += new Vector3(0.1f, 0, 0);
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
            transform.Translate(new Vector3(-0.1f, 0, 0));

        }
    }

    void OnMouseDrag()
    {


        if (Input.GetMouseButton(0))
        {
            gameObject.transform.localScale += new Vector3(-0.05f, 0, 0);


        }
        if (gameObject.transform.localScale.x < 0)
        {
            if (dist >= 3.63 && dist <= 5.3)
            {
                Gamefunction.Instance.AddScore();

            }
            if (dist >= 6.87 || dist <= 1.91)
            {
                Gamefunction.Instance.ReduceScore();
            }
            Destroy(gameObject);
            Instantiate(explo, transform.position, transform.rotation);
            if (tag == "Ball") //如果碰撞的標籤是Ship
            {
                Instantiate(explo, gameObject.transform.position, gameObject.transform.rotation);

                //在碰撞物件的位置產生爆炸，也就是在太空船的位置產生爆炸
            }

        }


    }



}


