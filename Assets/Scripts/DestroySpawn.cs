using UnityEngine;
using System.Collections;

public class DestroySpawn : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Enemy")
		{
			return;
		}
		Destroy(other.gameObject);
	}
}