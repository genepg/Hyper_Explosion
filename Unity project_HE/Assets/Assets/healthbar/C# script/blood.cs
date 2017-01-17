using UnityEngine;
using System.Collections;

public class blood : MonoBehaviour {

	//public float MaxHP;
	//public float HP;
	int cnt = 100;
    public bool tf = false;
	public static blood Instance;
	// Use this for initialization
	void Start () {
		Instance = this;
    }
		
	// Update is called once per frame
	void Update () {
		
	}

    public void sub_blood()
      {
        if (cnt >= 0)
        {
            gameObject.transform.localScale -= new Vector3(0.0008f, 0.0f, 0.0f);
            //new Vector3 (-0.1f ,0.0f,0.0f);
            cnt--;
        }
        if (100>= cnt)
        {
            gameObject.transform.localScale -= new Vector3(0.0008f, 0.0f, 0.0f);
            //new Vector3 (-0.1f ,0.0f,0.0f);
            cnt--;
        }

         if (cnt > 100)
        {
            gameObject.transform.localScale -= new Vector3(1.0f, 0.0f, 0.0f);
            //new Vector3 (-0.1f ,0.0f,0.0f);
            cnt--;
        }
    }
}


