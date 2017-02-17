using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class EnemuAttack : MonoBehaviour {
    public GameObject player;
    private PlayerHealth ph;
     private EnemyHealth eh;
    public int atackAmount = 10;
    public float timeToAttack = 0.5f;
    private bool isRange = false;
    private float timer;
 
	// Use this for initialization
	void Awake () {
        if (player == null) {

            player = GameObject.FindGameObjectWithTag("Shooter");
          
        }
        ph=player.GetComponent<PlayerHealth>();
        eh=GetComponent<EnemyHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (isRange && timer >= timeToAttack && eh.currentHealth > 0)
        {
           
            Attack();
            //
        }
       
		
	}
    void Attack() {
        if (ph.currentHealth > 0)
        {

            ph.GetHurt(atackAmount);
            timer = 0;
        }
    
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {

            isRange = true;
        }

    }
          void OnTriggerExit(Collider other)
    {

        if (other.gameObject == player) {

            isRange = false;
        }
    }
}
