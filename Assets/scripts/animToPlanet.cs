using UnityEngine;
using System.Collections;

public class animToPlanet : MonoBehaviour {

		private bool IsAnim = false;
		private int Level = 0;
		private float time = 0.0f;
		private float FOV_Org = 35;
		private float FOV_OUT = 179;
		private GameObject target;
		private Transform Backup;
		private float FOV = 35f;
		private float speed = 250.0254f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if( IsAnim ){
						if(Camera.main.fieldOfView <= FOV_OUT && Level == 0){
								FOV += Time.deltaTime * speed;
								Camera.main.fieldOfView = FOV;
						}
						else{
								if(Level == 0){Level++;}
								transform.LookAt(target.transform.position);
								if( time <= 5.0f && Level == 1){
										transform.rotation = Quaternion.AngleAxis(time*30, Vector3.up);
										time+=Time.deltaTime;
								}
								else{
										transform.position = (new Vector3(-1,0,0)) +  target.transform.position;
										if(Level == 1){Level++;}
										if(Camera.main.fieldOfView >= FOV_Org && Level == 2){
												FOV -= Time.deltaTime * speed * 2;
												Camera.main.fieldOfView = FOV;
										}	
										else{
												this.gameObject.GetComponent<move>().enabled = true;
												this.gameObject.GetComponent<mouseLook>().enabled = true;
												this.gameObject.transform.rotation = Backup.rotation;
												IsAnim = false;
												Level = 0;
												FOV = 35f;
												time = 0.0f;
										}
								}
						}
				}
	}

		public void PlayAnim(GameObject planet){
				this.gameObject.GetComponent<move>().enabled = false;
				this.gameObject.GetComponent<mouseLook>().enabled = false;
				this.gameObject.GetComponent<MouseLookAround>().enabled = false;
				Backup = this.gameObject.transform;
				GameObject.Find("Canvas").GetComponent<globalData>().target = planet;
				target = planet;
				IsAnim = true;
		}
}
