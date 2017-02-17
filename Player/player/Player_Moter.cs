using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Moter : MonoBehaviour {
    public float jumpPower = 5;
    public float gravity = -9f;

    private CharacterController mych;
    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        mych = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
        Gravity();
	}
    void Gravity() {
        if (!mych.isGrounded)
            moveDirection.y += gravity;
    
    
    }

    void Jump()
    {

        if (mych.isGrounded) {
            moveDirection.y = jumpPower;
        }
    }

}
