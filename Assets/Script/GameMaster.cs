using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
	public GameObject EnemyPrefab;

	float spawnInterval = 3;
	float timeSinceLastSpawn = 0;
	// Start is called before the first frame update
	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{
		
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn > spawnInterval)
		{
			Instantiate(EnemyPrefab);
			timeSinceLastSpawn = 0;
		}
	}
	public static void KillPlayer(Player player)
	{
		Destroy(player.gameObject);
	}
}