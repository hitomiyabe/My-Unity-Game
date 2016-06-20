using UnityEngine;
using System.Collections;

public class Cube1script : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + 0.1f, -3.4f, -5.7f);
		}
				
		

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x -0.1f, -3.4f ,- 5.7f);
		}
	}
}
