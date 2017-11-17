using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour {

    public Transform personaje;
    public float separacion = 6f;
	
	// Update is called once per frame
	/**
	 * Hace que la cámara siga al personaje
	 **/
	void Update () {
        transform.position = new Vector3(personaje.position.x+separacion, transform.position.y, transform.position.z);
		
	}
}
