using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int fullHealth=100;
    public int currentHealth;

	// Use this for initialization
	void Awake () {
        currentHealth = fullHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetHurt(int damageAmount) {
        currentHealth -= damageAmount;
        if(currentHealth<=0)
        {
            KillPlayer();

        }
    
    }
    void KillPlayer() {

        gameObject.SetActive(false);
    
    
    }
}
