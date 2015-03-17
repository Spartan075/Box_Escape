using UnityEngine;
using System.Collections;

public class moveBelt : MonoBehaviour {

	public float moveSpeed;


	Rigidbody rb;


	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {

		Vector3 vel = rb.velocity;

		vel.x = moveSpeed;

		rb.velocity = vel;

		if(transform.position.x > 30) {
			Vector3 pos = transform.position;

			pos.x = -30;

			transform.position = pos;
		}
	}
}
