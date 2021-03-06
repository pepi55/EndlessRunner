﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour {
	//privates
	private bool spawnEnemy = false;
	private List<GameObject> enemies = new List<GameObject>();
	private float counter = 0;
	private GameObject enemy = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		counter += 1 * Time.deltaTime;

		if (counter >= GlobalStatic.enemySpawnDelay) {
			counter = 0;
			spawnEnemy = true;
			GlobalStatic.enemySpawnDelay = Random.Range(1, 5);

			Spawn();
		}
	}

	private void Spawn () {
		if (spawnEnemy) {
			enemy = (GameObject)Instantiate(Resources.Load("Prefabs/Enemy/Enemies", typeof(GameObject)),
			                               new Vector3(GlobalStatic.screenSize.x + 5, 0, 0),
			                               Quaternion.identity);

			enemies.Add(enemy);
			spawnEnemy = false;
		}
	}
}
