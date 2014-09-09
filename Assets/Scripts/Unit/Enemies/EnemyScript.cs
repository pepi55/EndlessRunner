using UnityEngine;
using System.Collections;

public class EnemyScript : Unit {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckPosLeft();
		CheckPosDown();
	}

	void OnCollisionStay2D (Collision2D col) {
		if (col.collider.tag == GlobalStatic.playerTag) {
			Destroy(col.gameObject);
			Debug.Log("SHREKT.");
		}
	}
}
