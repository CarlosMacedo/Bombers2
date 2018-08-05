using UnityEngine;
using System.Collections;

public class Voar : MonoBehaviour {
	private int time_flutuar = 0;//voar
	private bool subir = true;
	public float velocidade;

	void voar(){
		if(subir){
			transform.Translate(Vector3.up * velocidade * Time.deltaTime);
		}
		else{
			transform.Translate(Vector3.down * velocidade * Time.deltaTime);
		}


		if(++time_flutuar > 30){
			time_flutuar = 0;
			subir = !subir;
		}
	}

	void Update(){
		voar ();
	}
}
