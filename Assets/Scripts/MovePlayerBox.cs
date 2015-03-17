using UnityEngine;
using System.Collections;

public class MovePlayerBox : MonoBehaviour {

	public float secondsToRoll;
	public float rollStep;
	public float waitTime;
	public bool canRotate;

	public Vector3 frontPivot;
	public Vector3 backPivot;
	public Vector3 leftPivot;
	public Vector3 rightPivot;
	
	public Rigidbody rb;
	
	void Update() {


		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		if(h == 1 && canRotate)
			StartCoroutine(rollAroundZForSeconds(rightPivot, -1));

		if(h == -1 && canRotate)
			StartCoroutine(rollAroundZForSeconds(leftPivot, 1));

		if(v == 1 && canRotate)
			StartCoroutine(rollAroundXForSeconds(frontPivot, 1));

		if(v == -1 && canRotate)
			StartCoroutine(rollAroundXForSeconds(backPivot, -1));

	}
	
	






	IEnumerator rollAroundXForSeconds(Vector3 pivot, int rollDir) {

		canRotate = false;

		pivot = transform.position + pivot;
		
		
		for(int x = 0; x <= (secondsToRoll * 60) - 3; x++) {
			
			transform.RotateAround(pivot, Vector3.right, rollStep * rollDir);
			
			yield return null;
			
		}

		yield return new WaitForSeconds(waitTime);
		canRotate = true;
		
	}

	IEnumerator rollAroundZForSeconds(Vector3 pivot, int rollDir) {
		
		canRotate = false;
		
		pivot = transform.position + pivot;
		
		
		for(int x = 0; x <= (secondsToRoll * 60) - 3; x++) {
			
			transform.RotateAround(pivot, Vector3.forward, rollStep * rollDir);
			
			yield return null;
			
		}

		yield return new WaitForSeconds(waitTime);
		canRotate = true;
		
	}

}
