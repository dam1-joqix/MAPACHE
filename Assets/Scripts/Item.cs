using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public int puntosAIncrementar = 5;
    bool incrementados = false;
	
	void Start () {
		
	}
	
	void Update () {
		
	}
    /**
     * Este metodo salta al colisionar algo con el item
     **/
    void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.gameObject.tag == "Player" && !incrementados)
        {
            incrementados = true;
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosAIncrementar);
        }
        Destroy(gameObject);
    }
}

