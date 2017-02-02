using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if( !GameObject.Find("Canvas").GetComponent<globalData>().FreeLook 
						//&& GameObject.Find("Canvas").GetComponent<globalData>().target
				){
						//GameObject.Find("Main Camera").transform.LookAt(GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position);
						//transform.position = (new Vector3(-1,0,0)) +  GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position;
						transform.RotateAround(GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position,new Vector3(0.0f,1.0f,0.0f),1);
				}
	}
}
