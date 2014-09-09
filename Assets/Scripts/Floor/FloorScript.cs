using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {
	//privates
	private Vector2 pos = new Vector2();

	// Use this for initialization
	void Start () {
		pos = new Vector2(this.transform.position.x, this.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		pos.x -= GlobalStatic.speed * Time.deltaTime;

		if (this.transform.position.x <= -GlobalStatic.levelSize) {
			pos.x += GlobalStatic.levelSize * GlobalStatic.numberOfFloors;
		}

		this.transform.position = pos;
	}
}
