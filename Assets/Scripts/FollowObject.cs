using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

	public Transform objectToFollow;
	public Vector3 offset;
	


	void Update () {
	
		transform.position = objectToFollow.position + offset;

	}
}
