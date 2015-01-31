﻿using UnityEngine;
using System.Collections;

public class ItemBreak : MonoBehaviour {

	public Transform shard;

	public float shardSpeed = 100f;

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
			for(int i = 1; i <= 5; i++)
			{
				int randomForce = Random.Range(20,70);
				Transform shardPart = (Transform)Instantiate (shard, transform.position, Quaternion.Euler(0, 0, (72*i)));
				shardPart.rigidbody2D.AddForce(shardPart.transform.right * randomForce * force);
			}
			Destroy(this.gameObject);
		}
	}
}