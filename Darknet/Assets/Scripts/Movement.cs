using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed;
    
	// WASD movement.
	public void InputMovement() {
		if (Input.GetKey(KeyCode.W)) {
			gameObject.rigidbody2D.MovePosition(gameObject.rigidbody2D.position + Vector2.up * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)) {
			gameObject.rigidbody2D.MovePosition(gameObject.rigidbody2D.position - Vector2.up * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)) {
			gameObject.rigidbody2D.MovePosition(gameObject.rigidbody2D.position + Vector2.right * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)) {
			gameObject.rigidbody2D.MovePosition(gameObject.rigidbody2D.position - Vector2.right * speed * Time.deltaTime);
		}
	}
}
