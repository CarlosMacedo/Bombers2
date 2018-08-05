using UnityEngine;
using System.Collections;

public class ColorLight : MonoBehaviour {
	public Light lt;

	void Start() {
		lt = GetComponent<Light>();
	}

	void Update() {
		lt.color = new Vector4(0.95f,0,0,1);
	}
}
