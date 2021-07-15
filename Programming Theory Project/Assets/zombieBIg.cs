using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieBIg : Zombie // INHERITANCE
{

	 
	[SerializeField]
	private int m_movementSpeed;


	//dis boi is slow af cuz hes biggus 
	public override void Moving() // POLYMORPHISM
	{
		base.Moving();
	}

	private void Start()
	{
		zombieRb = GetComponent<Rigidbody>();
		player = GameObject.Find("Player");
	}
	private void Update()
	{
		movementSpeed = m_movementSpeed;
		Moving();
	}
}
