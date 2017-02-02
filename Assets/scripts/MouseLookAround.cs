using UnityEngine;
using System.Collections;

public class MouseLookAround : MonoBehaviour {
		public float rotationSpeed   = 8.0f;
		//Vector3 offset;


	// Use this for initialization
	void Start () {
				//offset = transform.position - GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position;
	}
	
	// Update is called once per frame
		void Update () {
				
				//offset = transform.position - GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position;
				if(GameObject.Find("Canvas").GetComponent<globalData>().target){
						transform.LookAt(GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position);
						//offset = transform.position - GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position;
						transform.RotateAround(GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position, Vector3.up, Input.GetAxis("Mouse X")*rotationSpeed);//
						//transform.position = GameObject.Find("Canvas").GetComponent<globalData>().target.transform.position + offset;
				}	
		}

}
