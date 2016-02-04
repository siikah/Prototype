﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeivitFaux : MonoBehaviour {

	public List<GameObject> Objects;
	public float Gravity;
	Rigidbody MyRigidBody;
	float MASS = 0;
	// Use this for initialization
	void Start () {
		MyRigidBody = gameObject.GetComponent<Rigidbody> ();
		if (MyRigidBody != null) {
			MASS = MyRigidBody.mass;
		}

	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject GO in Objects) {
			if (GO.transform!=null)
			{

				Vector3 dir = transform.position - GO.transform.position;
				dir = dir.normalized;
				Rigidbody RB = GO.GetComponent<Rigidbody>();
				float Distance = Vector3.Distance(transform.position,GO.transform.position);
				RB.AddForce(((Gravity*dir)/Distance)*MASS,ForceMode.Force);

			}
		}
	}
}