using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Boundary boundary;
	public int life;
	
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;
	
	public Quaternion rotation;
	public Vector3 radius = new Vector3(0,0,0);
	public float currentRotation = 0.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	void FixedUpdate ()
	{
		//rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
		currentRotation += Input.GetAxis ("Horizontal")*Time.deltaTime*-100;
		rotation.eulerAngles = new Vector3(0, currentRotation, -9);
		transform.position = rotation * radius;
		transform.rotation = rotation;
		
	}
}
