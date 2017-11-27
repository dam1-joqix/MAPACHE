using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
	public float velocidad = 0f;
	float tiempoInicio=0f;
	bool corriendo=false;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeMuere");
	}
	void PersonajeEmpiezaACorrer(){
		corriendo = true;
		tiempoInicio = Time.time;
	}
	void PersonajeMuere(){
		corriendo = false;
	}
	// Update is called once per frame
	void Update () {
		if (corriendo) {
			GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (((Time.time - tiempoInicio) * velocidad) % 1, 0);
		}
	}
}
