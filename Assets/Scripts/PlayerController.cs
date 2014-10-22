using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
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

	public GUIText lifeText;

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			audio.Play ();
		}
		lifeText.text = "Remaining Lives: " + life;
	}

	void FixedUpdate ()
	{
		//rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
		currentRotation += Input.GetAxis ("Horizontal")*Time.deltaTime*-100;
		rotation.eulerAngles = new Vector3(0, currentRotation, -9);
		transform.position = rotation * radius;
		transform.rotation = rotation;
	}

	public int DecreaseLife ()
	{
		life--;
		lifeText.text = "Remaining Lives: " + life;
		return life;
	}
}

/*float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.velocity = movement * speed;
		
		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
		
		rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);*/