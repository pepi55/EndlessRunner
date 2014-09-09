using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	//privates
	private GameObject floor = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Translate(new Vector2(GlobalStatic.speed, 0) * Time.deltaTime);
		}

		if (floor != null && Input.GetKeyUp(KeyCode.UpArrow)) {
			//this.transform.Translate(new Vector2(0, GlobalStatic.speed) * Time.deltaTime);
			this.rigidbody2D.AddForce(new Vector2(0, GlobalStatic.speed * 100));
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