using UnityEngine;
using System.Collections;

public class testBoxMove : MonoBehaviour {

	public float rollForce;

	public Rigidbody rb;
	

	// Update is called once per frame
	void Update () {

		float v = Input.GetAxisRaw("Vertical");
		float h = Input.GetAxisRaw("Horizontal");

		if(h == 0)
			rb.AddTorque(transform.right * v * rollForce * Time.deltaTime);

		if(v == 0)
			rb.AddTorque(transform.forward * -h * rollForce * Time.deltaTime);
	
	}
}
