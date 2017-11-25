using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntosBloque : MonoBehaviour {
	private int puntosAIncrementar =1;
	private bool haColisionadoConElJugador = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D colision){
		if ((haColisionadoConElJugador == false) && (colision.gameObject.tag == "Player") && (colision.contacts[0].collider.gameObject.name!="Cabeza") && (colision.contacts[0].collider.gameObject.name != "Cuerpo")) {
			haColisionadoConElJugador = true;
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", puntosAIncrementar);
		}
	}
}
