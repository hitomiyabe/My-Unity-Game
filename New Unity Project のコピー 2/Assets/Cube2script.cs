using UnityEngine;
using System.Collections;

public class Cube2script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position = new Vector3 (-0.4f, transform.position.y + 0.1f, -7.6f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position = new Vector3 (-0.4f, transform.position.y - 0.1f, -7.6f);
		}
	}
}
