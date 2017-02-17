using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieInstation : MonoBehaviour {
    public GameObject zombie;
 
	// Use this for initialization
	void  OnTriggerEnter(Collider other) {
 
        if (other.gameObject.tag == "Player") {

            Instantiate(zombie, transform.position, transform.rotation);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
