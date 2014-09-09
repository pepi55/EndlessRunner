using UnityEngine;
using System.Collections;

public class PlayerScript : Unit {
	//publics
	//public static bool dead = false;

	// Use this for initialization
	void Start () {
		GlobalStatic.speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			if (floor != null) {
				this.transform.Translate(new Vector2(GlobalStatic.speed, 0) * Time.deltaTime);
			} else {
				this.transform.Translate(new Vector2(GlobalStatic.speed * 0.2f, 0) * Time.deltaTime);
			}
		}
		
		if (floor != null && Input.GetKeyUp(KeyCode.UpArrow)) {
			//this.transform.Translate(new Vector2(0, GlobalStatic.speed) * Time.deltaTime);
			this.rigidbody2D.AddForce(new Vector2(0, GlobalStatic.speed * 100));
		}

		CheckPosUp();
		CheckPosRight();
		CheckPosLeft();
		CheckPosDown();
	}
}