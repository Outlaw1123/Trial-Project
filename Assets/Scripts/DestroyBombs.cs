using UnityEngine;
using System.Collections;

public class DestroyBombs : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		Destroy(other.gameObject);
	}
}