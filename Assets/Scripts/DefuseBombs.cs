using UnityEngine;
using System.Collections;

public class DefuseBombs : MonoBehaviour
{
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			return;
		}
		Destroy(other.gameObject);
	}
}