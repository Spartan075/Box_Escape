using UnityEngine;
using System.Collections;

public class testBoxMove : MonoBehaviour {

	public float rollForce;

	Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

		float v = Input.GetAxisRaw("Vertical");
		float h = Input.GetAxisRaw("Horizontal");

		if(h == 0)
			rb.AddRelativeTorque(new Vector3(v * rollForce * Time.deltaTime, 0, 0));

		if(v == 0)
			rb.AddRelativeTorque(new Vector3(0, 0, h * rollForce * Time.deltaTime));
	
	}
}
