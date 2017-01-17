using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controllongball : MonoBehaviour {
    public Image current;
    bool MouseC = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (MouseC == true)
        {
            current.transform.localScale += new Vector3(-0.01f, 0, 0);
        }
    }
    void OnMouseDrag()
    {
        MouseC = true;
       /* if (Input.GetMouseButton(0))
        {
            current.transform.localScale += new Vector3(-0.01f, 0, 0);


        }*/
        if (current.transform.localScale.x < 0)
        {
            Destroy(current);

        }


    }
}
