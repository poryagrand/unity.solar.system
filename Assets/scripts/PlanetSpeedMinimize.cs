using UnityEngine;
using System.Collections;

public class PlanetSpeedMinimize : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		void Update () {
				if( (this.gameObject.transform.position - GameObject.Find("Main Camera").transform.position).magnitude <= 5 && (this.gameObject.transform.position - GameObject.Find("Main Camera").transform.position).magnitude >= 0 ){
						GameObject.Find("Canvas").GetComponent<globalData>().Earth_H = 0.0000002f;
				}
		}
}
