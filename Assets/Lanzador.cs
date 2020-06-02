using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzador: MonoBehaviour
{
	public GameObject prefab;
	public GameObject prefabRandom;
	GameObject bola;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			bola = Instantiate (prefab, transform.position, transform.rotation) as GameObject;
			Destroy (bola, 8f);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			bola = Instantiate (prefabRandom, transform.position, transform.rotation) as GameObject;
			Destroy (bola, 8f);
		}
	}
}