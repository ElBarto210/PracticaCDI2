using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour {

	int contador;
	public Text puntuacion;

	// Use this for initialization
	void Start () {
		contador = 0;
		puntuacion.text = "Puntuación:  " + contador;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider collider){
		contador = contador + 1;
		puntuacion.text = "Puntuación:  " + contador;

	}
}