using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected Joystick joystick;
	public Joybutton joybutton;
	
	private Rigidbody playerRb;
    private float speed = 1000;
	public float jumpSpeed = 10f;
	public Transform cam;
	public Vector3 MoveVector;
	public bool grounded = true;
	
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
		playerRb = GetComponent<Rigidbody>();
    }
	
    void FixedUpdate()
    {
		//declare movement of the player
		Vector3 dir = Vector3.zero;
		dir.x = joystick.Horizontal;
		dir.z = joystick.Vertical;
		if (dir.magnitude >= 0.1f) {
			dir.Normalize();
		}
		Vector3 MoveVector = new Vector3(dir.x, 0.0f, dir.z);
		
		//move the player
		playerRb.AddForce(MoveVector * speed * Time.deltaTime);
		
		//make player jump
		if (joybutton.Pressed && grounded) {
			playerRb.AddForce(new Vector3 (0, 15, 0), ForceMode.Impulse);
			grounded = false;
		}
    }
	
	void OnCollisionEnter(Collision collision) {
		grounded = true;
	}
}
