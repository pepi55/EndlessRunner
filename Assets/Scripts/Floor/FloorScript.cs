using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {
	//privates
	private Vector2 pos = new Vector2();
	private float levelSize = 12.5f;

	// Use this for initialization
	void Start () {
		pos = new Vector2(this.transform.position.x, this.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		pos.x -= GlobalStatic.speed * Time.deltaTime;

		if (this.transform.position.x <= -levelSize) {
			pos.x += levelSize * 2;
		}

		this.transform.position = pos;
	}
}
