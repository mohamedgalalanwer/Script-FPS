using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    RaycastHit rayCast;
    public int rang = 300;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out rayCast, rang))
            {
                Debug.Log("enmy: "+rayCast.transform.name);
            
            }
        }
    }
}
