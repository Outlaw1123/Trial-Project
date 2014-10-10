using UnityEngine;
using System.Collections;

public class RotateEngine : MonoBehaviour {
	public Quaternion rotation;
	public Vector3 radius = new Vector3(0,0,0);
	public float currentRotation = 0.0f;

	// Use this for initialization
	void FixedUpdate ()
	{
		currentRotation += Input.GetAxis ("Horizontal")*Time.deltaTime*100;
		rotation.eulerAngles = new Vector3(0, currentRotation, 0);
		transform.position = rotation * radius;
		transform.rotation = rotation;
	}
}
