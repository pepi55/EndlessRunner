using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {
	//publics
	public int scrollSpeed = 5;

	//privates
	private Vector2 pos = new Vector2();

	// Use this for initialization
	void Start () {
		pos = new Vector2(this.transform.position.x, this.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		pos.x -= scrollSpeed * Time.deltaTime;

		if (this.transform.position.x <= -12.5f) {
			pos.x += 25f;
		}

		this.transform.position = pos;
	}
}
