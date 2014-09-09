using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	//publics
	public static bool dead = false;

	//privates
	private GameObject floor = null;

	// Use this for initialization
	void Start () {
		GlobalStatic.speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (!dead) {
			if (Input.GetKey(KeyCode.RightArrow)) {
				if (floor != null) {
					this.transform.Translate(new Vector2(GlobalStatic.speed, 0) * Time.deltaTime);
				} else {
					this.transform.Translate(new Vector2(GlobalStatic.speed * 0.4f, 0) * Time.deltaTime);
				}
			}
			
			if (floor != null && Input.GetKeyUp(KeyCode.UpArrow)) {
				//this.transform.Translate(new Vector2(0, GlobalStatic.speed) * Time.deltaTime);
				this.rigidbody2D.AddForce(new Vector2(0, GlobalStatic.speed * 50));
			}
		}
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.collider.tag == GlobalStatic.floorTag) {
			floor = (GameObject)col.collider.gameObject;

			this.transform.parent = floor.transform;
		}
	}

	void OnCollisionExit2D (Collision2D col) {
		if (col.collider.gameObject.transform == transform.parent) {
			this.transform.parent = null;
			floor = null;
		}
	}
}