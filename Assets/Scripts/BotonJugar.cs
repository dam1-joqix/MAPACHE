using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Este script controla el botón jugar
 * */
public class BotonJugar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/**
	 * Al pulsar se carga GameScene
	 **/
	void OnMouseDown(){
		Application.LoadLevel ("GameScene");
	}
}
