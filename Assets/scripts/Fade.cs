using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {
		private float TimeToLoadStartLevel = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if( TimeToLoadStartLevel != -1 ){
						if( TimeToLoadStartLevel >= 133 ){
								TimeToLoadStartLevel = -1;
								StartCoroutine(Out());
						}
						else{ TimeToLoadStartLevel += Time.deltaTime; }
				}
	
	}

		IEnumerator Out(){//IEnumerable
				float time = GetComponent<globalData>().BeginFade(1);
				yield return new WaitForSeconds(time * 15);
				SceneManager.LoadScene("game");
		}
}
