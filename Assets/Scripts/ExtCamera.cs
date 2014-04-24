﻿using UnityEngine;
using System.Collections;

public class ExtCamera : MonoBehaviour {

	public const float ACCEL_COEFF = 3.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount == 1) //Move square
		{
			rigidbody.AddForce(
				//transform.Translate(
				-Input.touches[0].deltaPosition.x * .5f * this.transform.position.y, 
				0,
				-Input.touches[0].deltaPosition.y * .5f * this.transform.position.y);
		}

		if(Input.touchCount == 2)
		{
			//Pre-delta distance
			float dist = Vector2.Distance(Input.touches[0].position,
			                              Input.touches[1].position);
			
			//Post-delta distance
			float distDelta = Vector2.Distance(
				-Input.touches[0].position + Input.touches[0].deltaPosition,
				-Input.touches[1].position + Input.touches[1].deltaPosition);
			
			transform.Translate(0, 0, (dist - distDelta) * .025f);
		}
	}
}
