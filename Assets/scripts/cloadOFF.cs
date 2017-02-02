using UnityEngine;
using System.Collections;

public class cloadOFF : MonoBehaviour {

		private float count = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				count = (count + 0.0001f)%1;
				this.gameObject.GetComponent<MeshRenderer>().materials[1].SetTextureOffset("_MainTex", new Vector2(count,0));
	}
}
