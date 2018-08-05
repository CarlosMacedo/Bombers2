using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	private int cont;

	void Start() {
		cont = 1;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.V)) {
			Debug.Log (cont);
			if (cont == 1) {
				camera1.enabled = true;
				camera2.enabled = false;
				camera3.enabled = false;
				Debug.Log (cont);
			} else if (cont == 2) {
				camera1.enabled = false;
				camera2.enabled = true;
				camera3.enabled = false;
			} else {
				camera1.enabled = false;
				camera2.enabled = false;
				camera3.enabled = true;
				cont = 0;
			}
			cont++;
		}
	}
}