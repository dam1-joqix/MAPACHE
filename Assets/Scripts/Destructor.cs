using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {
	GameObject personaje;
	// Use this for initialization
	void Start () {
		personaje=GameObject.Find("Personaje");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "PersonajeMuere");
			personaje.SetActive(false);
			//gameOver
		} else {
			Destroy(collision.gameObject);
		}
        
    }
}
