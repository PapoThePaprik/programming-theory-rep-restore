using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSmall : Zombie // INHERITANCE
{
	[SerializeField]
	private int m_movementSpeed;


	//this boi is fast af cuz hes smull
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
