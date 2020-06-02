using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaRandom : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody> ().AddForce (new Vector3 (Random.Range(-0.4f, 0.4f), Random.Range(19.5f, 20.5f), Random.Range(-7.5f, -8.5f)), ForceMode.Impulse);

	}

	// Update is called once per frame
	void Update () {

	}
}
