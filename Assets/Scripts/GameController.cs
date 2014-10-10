using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValue;
	public int bombCount;
	public float startWait;
	public float spawnWait;

	void Start ()
	{
		StartCoroutine (spawnWaves ());
	}

	IEnumerator spawnWaves ()
	{
		yield return new WaitForSeconds(startWait);
		for (int i = 0; i<bombCount; i++) 
		{
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValue.x, spawnValue.x), spawnValue.y, Random.Range (-spawnValue.z, spawnValue.z));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds(spawnWait);
		}
	}
}
