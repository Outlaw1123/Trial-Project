using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;
	private PlayerController playerController;

	private Transform defuse; // drag the player here
	public float speed = 5.0f; // move speed

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script!");
		}

		GameObject playerControllerObject = GameObject.FindWithTag ("Player");
		if (playerControllerObject != null)
		{
			playerController = playerControllerObject.GetComponent <PlayerController>();
		}
		if (playerController == null)
		{
			Debug.Log ("Cannot find 'PlayerController' script!");
		}
	}
	
	void Update()
	{
		GameObject bombDefuseBoundary = GameObject.FindWithTag ("BombDefuseBoundary");
		defuse = bombDefuseBoundary.GetComponent<Transform> ();
		transform.position = Vector3.MoveTowards(transform.position, defuse.position, -speed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("Collision: " + collider.name + "\tWith: " + other.gameObject.name);

		if (other.tag == "SpawnBoundary" || other.tag == "BombDefuseBoundary")
		{
			return;
		}

		else if (other.tag == "Player")
		{
			int life = playerController.DecreaseLife ();
			if (life == 0)
			{
				Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
				gameController.GameOver ();
			}
		}

		else
		{
			gameController.AddScore (scoreValue);
			Destroy (other.gameObject);
		}

		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}
	
	void OnTriggerExit (Collider other)
	{
		Instantiate (explosion, transform.position, transform.rotation);
		if (other.tag == "BombDefuseBoundary")
		{
			Destroy (gameObject);
			return;
		}
	}
}