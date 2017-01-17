using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public float dist;
	public GameObject explo; 

	// Use this for initialization
	void Start () {

	}
	 
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3(0,0,0);
		Debug.Log (transform.position);

		//enemy going down
		gameObject.transform.position += new Vector3(0,-0.01f,0);

		dist = Vector3.Distance(pos, gameObject.transform.position);

		if (dist >= 10) {
			blood.Instance.sub_blood();
		}

		if(dist >= 14){
			
			Destroy(gameObject);
		}
			
		}
		
		void OnMouseDown(){
			Destroy(gameObject);
			Gamefunction.Instance.AddScore(); //****************************

			Instantiate(explo,transform.position,transform.rotation); //動畫產生
			
			if (tag == "Enemy") //如果點擊的標籤是Enemy
			{
				Instantiate(explo, gameObject.transform.position, gameObject.transform.rotation);
			//在碰撞物件的位置產生爆炸，也就是在太空船的位置產生特效
				
			}
		}

}
