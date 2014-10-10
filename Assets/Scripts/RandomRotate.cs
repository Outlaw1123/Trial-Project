using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour {

	public float tumble;

	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
