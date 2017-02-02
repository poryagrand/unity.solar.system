using UnityEngine;
using System.Collections;

public class End_camera : MonoBehaviour {

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
				if( (this.gameObject.transform.position - GameObject.Find("Main Camera").transform.position).magnitude <= 5 && (this.gameObject.transform.position - GameObject.Find("Main Camera").transform.position).magnitude >= 0){
						trace();
				}
		}
		public void trace(){
				string[] a = {"Mercury","Venus","Earth","Mars","Jupiter","saturn","Uranus","Neptune"};
				foreach( string b in a ){
						_trace(b);
				}
		}

		private void _trace( string name ){
				GameObject.Find(name).GetComponent<TrailRenderer>().startWidth = 10;
				GameObject.Find(name).GetComponent<TrailRenderer>().endWidth = 10;
		}

}
