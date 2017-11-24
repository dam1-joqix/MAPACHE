using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
	private int puntuacion = 0;
	// Use this for initialization
	void Start ()
	{
		NotificationCenter.DefaultCenter ().AddObserver (this, "IncrementarPuntos");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void IncrementarPuntos (Notification notificacion)
	{
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion += puntosAIncrementar;
		/**
		 * Para comprobar que funcione
		 **/
		Debug.Log ("Puntos incrementados: " + puntosAIncrementar + ", TOTAL: " + puntuacion);
	
	}
}
