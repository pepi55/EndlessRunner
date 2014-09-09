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
}
