using UnityEngine;
using System.Collections;

public class contrlong : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    void OnMouseDrag()
    {

        if (Input.GetMouseButton(0))
        {
            gameObject.transform.localScale += new Vector3(-0.01f, 0, 0);


        }
        if (gameObject.transform.localScale.x < 0)
        {
            Destroy(gameObject);

        }


    }
}
