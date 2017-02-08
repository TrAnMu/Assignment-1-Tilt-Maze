using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.isKinematic == true) {
			transform.Translate (Vector3.up * Time.deltaTime, Space.World);
		}

		if (Input.GetKey ()) {

		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Goal") {
			rb.isKinematic = true;
		}
	}
}
