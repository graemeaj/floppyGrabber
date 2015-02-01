﻿using UnityEngine;
using System.Collections;

public class babyFling : MonoBehaviour {
	
	
	
	public Transform cartoonBaby;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		float force = this.rigidbody2D.velocity.magnitude + collision.gameObject.rigidbody2D.velocity.magnitude;
		print (force);
		if(force > 1f)
		{
			
			int randomForce = Random.Range(70,400);
			Transform baby = (Transform)Instantiate (cartoonBaby, transform.position, Quaternion.Euler(0, 0, (72)));
			baby.rigidbody2D.AddForce(cartoonBaby.transform.right * randomForce * force);
			baby.rigidbody2D.AddTorque((float)randomForce * 3);
		}
	}
}
