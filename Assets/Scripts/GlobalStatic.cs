using UnityEngine;
using System.Collections;

public static class GlobalStatic {
	//string
	public static string playerTag = "Player";
	public static string floorTag = "Floor";
	public static string enemyTag = "Enemy";

	//int
	public static int numberOfFloors = 11;

	//float
	public static float levelSize = 3.0f;
	public static float enemySpawnDelay = 1.0f;
	public static float speed = 5.0f;

	//vector4
		public static Vector4 screenSize = new Vector4(6.5f, 6.0f, -2.0f, -6.0f);
}