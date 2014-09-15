using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	//protected
	protected GameObject floor = null;

	//private
	private Vector2 pos = new Vector2();

	/*void OnCollisionEnter2D (Collision2D col) {
		if (floor == null && col.collider.tag == GlobalStatic.floorTag) {
			floor = (GameObject)col.collider.gameObject;
			
			this.transform.parent = floor.transform;
		}
	}*/
	
	void OnCollisionExit2D (Collision2D col) {
		if (col.collider.gameObject.transform == transform.parent) {
			this.transform.parent = null;
			floor = null;
		}
	}

	void OnCollisionStay2D (Collision2D col) {
		if (col.collider.tag == GlobalStatic.floorTag) {
			if (floor != null) {
				floor = (GameObject)col.collider.gameObject;
			}

			this.transform.parent = col.collider.gameObject.transform;
		}
	}

	protected void CheckPosRight () {
		if (this.transform.position.x >= GlobalStatic.screenSize.x) {
			pos = this.transform.position;
			pos.x = GlobalStatic.screenSize.x;

			this.transform.position = pos;
		}
	}

	protected void CheckPosUp () {
		if (this.transform.position.y >= GlobalStatic.screenSize.y) {
			pos = this.transform.position;
			pos.y = GlobalStatic.screenSize.y;

			this.transform.position = pos;
		}
	}

	protected void CheckPosLeft () {
		if (this.transform.position.x <= GlobalStatic.screenSize.z) {
			Destroy(this.gameObject);
		}
	}

	protected void CheckPosDown () {
		if (this.transform.position.y <= GlobalStatic.screenSize.w) {
			Destroy(this.gameObject);
		}
	}
}
