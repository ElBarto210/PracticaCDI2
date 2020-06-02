using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, 20.0f, -8.0f), ForceMode.Impulse);

	}

	// Update is called once per frame
	void Update () {

	}
}
