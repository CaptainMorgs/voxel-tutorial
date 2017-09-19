using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject player;
	public Vector3 spawnPoint = new Vector3(65f,110f,10f);

	// Use this for initialization
	void Start () {
		SpawnPlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnPlayer()
	{
		Instantiate(player,spawnPoint,Quaternion.identity);
	}
}
