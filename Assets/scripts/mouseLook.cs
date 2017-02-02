using UnityEngine;
using System.Collections;

public class mouseLook : MonoBehaviour {
		public float mouseSensitivity   = 1.0f;
		private Vector3 lastPosition ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame


		void Update()
		{
				/*
				if (Input.GetMouseButtonDown(0))
				{
						lastPosition = Input.mousePosition;
				}

				if (Input.GetMouseButton(0))
				{
						Vector3 delta = Input.mousePosition - lastPosition;
						transform.Translate(delta.x * mouseSensitivity, delta.y * mouseSensitivity, 0);
						lastPosition = Input.mousePosition;
				}
*/
				//transform.Translate(Input.GetAxis("Mouse X") * mouseSensitivity, Input.GetAxis("Mouse Y") * mouseSensitivity, 0);
				transform.Rotate(new Vector3((-1)*(Input.GetAxis("Mouse Y") * mouseSensitivity),(Input.GetAxis("Mouse X") * mouseSensitivity), 0));
		}
}
