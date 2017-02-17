using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int fullHealth = 100;
    public int currentHealth;
    private bool isDead;
    public int scoreValue=10;
   
	// Use this for initialization
	void Awake () {
        currentHealth = fullHealth;
	}
	
	// Update is called once per frame


    
    public void GutHurt (int damage) {
        if (isDead) {
            return;
        }
        currentHealth -= damage;
        if (currentHealth <= 0) {
          
            KillEnemy();
        }
	}
    void KillEnemy() {
        isDead = true;
        ScoreDirector.score += scoreValue;
        Destroy(gameObject,0.2f);
    
    
    
    }
}
