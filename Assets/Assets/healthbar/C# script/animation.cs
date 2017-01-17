using UnityEngine;
using System.Collections;

public class animation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AnimationEnd() 
	{
		Destroy (gameObject); //消滅物件
	}
}
