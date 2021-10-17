using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected Joystick joystick;
	protected Joybutton joybutton;
	
	private Rigidbody playerRb;
    private float speed = 1000;
	public Transform cam;
	public Vector3 MoveVector;
	
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
		joybutton = FindObjectOfType<Joybutton>();
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
    }
}
