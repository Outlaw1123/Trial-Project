using UnityEngine;
using System.Collections;

public class DestroySpawn : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player")
		{
			return;
		}
		Destroy(other.gameObject);
	}
}