using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

	public Rigidbody zombieRb;
	public GameObject player;
	
	Vector3 lookDirection;
	
	public float movementSpeed { get;  set; } // ENCAPSULATION





	private void FixedUpdate()
	{
		Moving();
	}

	public virtual void Moving() // ABSTRACTION
	{
		lookDirection = player.transform.position - transform.position;
		zombieRb.AddForce((lookDirection).normalized * movementSpeed * Time.deltaTime);

	}
}
