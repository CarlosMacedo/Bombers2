using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float turnSpeed;
	public float respawX, respawY, respawZ;

	void Update () {
		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * speed * Time.deltaTime);

		if(Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * speed * Time.deltaTime);

		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.R)) {
			transform.position = new Vector3 (respawX, respawY, respawZ);
			transform.localEulerAngles = new Vector3 (0, 0, 0);
		}
	}
}