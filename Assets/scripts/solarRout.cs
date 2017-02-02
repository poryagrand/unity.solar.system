using UnityEngine;
using System.Collections;

public class solarRout : MonoBehaviour {
	public Transform target;
 
	//public float orbitDistance = 10.0f;
		private float earth_H;
		public float day = 1.0f;
		public float degree = 0;
 
	private Vector3 relativeDistance = Vector3.zero;
 
	void Start () {
		if(target != null)
			relativeDistance = transform.position - target.position;
	}
 
	void FixedUpdate () {
				earth_H = GameObject.Find("Canvas").GetComponent<globalData>().Earth_H;
				if(target != null) {
						// Keep us at the last known relative position
						float hour = day * earth_H * 60 * 60;
						float rot = -((Time.deltaTime*360)/hour);

						transform.position = target.position + relativeDistance;
						transform.RotateAround(target.position, new Vector3( 0,Mathf.Sin( Mathf.Deg2Rad * (degree+90)),Mathf.Cos(Mathf.Deg2Rad * (degree+90)) ), rot);
						// Reset relative position after rotate
						relativeDistance = transform.position - target.position;

				}

	}
}
