using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class DestroyEnemy : MonoBehaviour {
    
	// Use this for initialization
     void Start() {
        
        Destroy(gameObject,3f);
    
    }
	
	// Update is called once per frame
	void Update () {
       
	}
}
