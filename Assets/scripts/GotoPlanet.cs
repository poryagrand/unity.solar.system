using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GotoPlanet : MonoBehaviour,IPointerClickHandler {
		public GameObject target;

	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		public void OnPointerClick(PointerEventData e){
				GameObject.Find("Main Camera").GetComponent<animToPlanet>().PlayAnim(target);
		}
}
