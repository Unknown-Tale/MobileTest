using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 1500;
	public Transform cam;
	public Vector3 MoveVector;
	
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
	
    void FixedUpdate()
    {
		//declare movement of the player
		Vector3 dir = Vector3.zero;
		dir.x = Input.GetAxis("Horizontal");
		dir.z = Input.GetAxis("Vertical");
		if (dir.magnitude >= 0.1f) {
			dir.Normalize();
		}
		Vector3 MoveVector = new Vector3(dir.x, 0.0f, dir.z);
		
		//move the player
		playerRb.AddForce(MoveVector * speed * Time.deltaTime);
    }
}
