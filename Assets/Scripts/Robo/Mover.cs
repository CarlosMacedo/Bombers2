using UnityEngine;
using System.Collections;
using System;
using UnityEngine;

public class Mover : MonoBehaviour {
    System.Random rnd = new System.Random();
    public float speed;
    int time;
    int lado;
    int mudar_lado;

    void sortear_lado(){
        lado = rnd.Next(1, 4);
    }

    void mudar_direcao(){        
        sortear_lado();
        sortear_tempo_mudanca_direcao();
          
        if (lado == 1){
            transform.Rotate(0, 90, 0);
        }

        else if (lado == 2){
            transform.Rotate(0, -90, 0);
        }

        else if (lado == 3){
            transform.Rotate(0, 180, 0);
        }   
    }

    void verifica_tempo(){
        if (time == mudar_lado){
            mudar_direcao();
        }
    }

    void zerar_time(){
        time = 0;
    }

    void sortear_tempo_mudanca_direcao(){
        mudar_lado = rnd.Next(30, 300);
        zerar_time();
    }

    void mover(){
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        time++;
        verifica_tempo();
    }

    
    // Use this for initialization
    void Start (){
        sortear_tempo_mudanca_direcao();
    }
        	
	// Update is called once per frame
	void Update () {
        mover();
    }

    void OnCollisionEnter(Collision colidir){
        if (colidir.gameObject.tag == "Walls" || colidir.gameObject.tag == "Mob"){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            mudar_direcao();
        }
    }
}
