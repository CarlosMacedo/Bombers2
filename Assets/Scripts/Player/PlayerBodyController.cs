using UnityEngine;
using System.Collections;

public class PlayerBodyController : MonoBehaviour {
	public float speedRotate;


	void Update () {
		if(Input.GetKey(KeyCode.W))
			transform.Rotate(Vector3.back, speedRotate * Time.deltaTime);

		if(Input.GetKey(KeyCode.S))
			transform.Rotate(Vector3.forward, speedRotate * Time.deltaTime);

		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.right, speedRotate * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.left, speedRotate * Time.deltaTime);
	}
}
