using UnityEngine;
using System.Collections;

public class selfRoutate : MonoBehaviour {
		/*
		public float speed = 0.0f;
		float y = 0.0f;
		float Deg = 0;

	// Use this for initialization
	void Start () {
				float sec = 1 / Time.deltaTime;
				float newSpeed = speed / (sec * 3600);

				Deg = ( newSpeed * 360 ) / 0.4379f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate (){
				

		this.gameObject.transform.rotation = Quaternion.AngleAxis(y, Vector3.up);	
				y -= Deg;
	}
	*/
		private float earth_H;
		public float day = 1.0f;
		//private float sec = 0.0f;

		void Start(){
				
		}

		void FixedUpdate(){
				earth_H = GameObject.Find("Canvas").GetComponent<globalData>().Earth_H;
				float hour = day * earth_H * 60 * 60;
				float rot = -((Time.deltaTime*360)/hour);
				//sec = sec - Time.deltaTime;
				//current = current - ((sec*hour)/360);

				//this.gameObject.transform.rotation = Quaternion.AngleAxis(rot, center);	
				//transform.RotateAround(this.gameObject.transform.localPosition, this.gameObject.transform.rotation, rot);
				transform.Rotate(new Vector3(0,0,rot),Space.Self);
		}
}
