using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class globalData : MonoBehaviour {

		public float Earth_H = 23.93f;
		private float EHO = 23.93f;
		public bool FreeLook = true;
		public GameObject target; 

		public Texture2D fadeOutTexture;
		public float fadeSpeed = 0.2f;

		private int drawDepth = -1000;
		private float alpha = 1.0f;
		public int fadeDir = -1;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
				
	}



		public void changeSpeed(Slider slide){
				Earth_H = EHO / slide.value;
				GameObject.Find("OD").GetComponent<Text>().text = Earth_H.ToString();
		}

		public void Chase(){ 
				if( target ){
						GameObject.Find("Main Camera").GetComponent<MouseLookAround>().enabled = true;
						GameObject.Find("Main Camera").GetComponent<mouseLook>().enabled = false; 
						//GameObject.Find("Main Camera").transform.parent = target.transform;
				}
		}
		public void Flook(){ 
				GameObject.Find("Main Camera").GetComponent<MouseLookAround>().enabled = false;
				GameObject.Find("Main Camera").GetComponent<mouseLook>().enabled = true; 
				//GameObject.Find("Main Camera").transform.parent = null;
		}

		public void trace(){
				string[] a = {"Mercury","Venus","Earth","Mars","Jupiter","saturn","Uranus","Neptune"};
				foreach( string b in a ){
						_trace(b);
				}
		}

		private void _trace( string name ){
				GameObject.Find(name).GetComponent<TrailRenderer>().startWidth = GameObject.Find(name).GetComponent<TrailRenderer>().startWidth == 0?1:0;
				GameObject.Find(name).GetComponent<TrailRenderer>().endWidth = GameObject.Find(name).GetComponent<TrailRenderer>().endWidth == 0?1:0;
		}

		public void MoveSpeed(Slider s){
				GameObject.Find("Main Camera").GetComponent<move>().speed = s.value;
				GameObject.Find("SD").GetComponent<Text>().text = s.value.ToString();
		}

		public void MouseSens(Slider s){
				GameObject.Find("Main Camera").GetComponent<mouseLook>().mouseSensitivity = s.value;
				GameObject.Find("MD").GetComponent<Text>().text = s.value.ToString();
		}

		void OnGUI(){
				alpha += fadeDir * fadeSpeed * Time.deltaTime;
				alpha = Mathf.Clamp01(alpha);
				GUI.color = new Color(GUI.color.r,GUI.color.g,GUI.color.b,alpha);
				GUI.depth = drawDepth;
				GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),fadeOutTexture);
		}
		public float BeginFade(int direction){
				fadeDir = direction;
				return (fadeSpeed);
		}

		public void Exit(){
				Application.Quit();
		}
				
}
