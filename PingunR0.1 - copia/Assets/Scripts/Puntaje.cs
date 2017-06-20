using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntaje : MonoBehaviour {

    public float puntajeGanado;
    public Text textoDePuntaje;
	public Text gameOverPuntaje;

	void Awake (){


		DontDestroyOnLoad (transform.gameObject);
	}

	void Start () {
        puntajeGanado = 0f;
		
	}
	
	void Update () {


        puntajeGanado = puntajeGanado + Time.deltaTime * 100;
    	Escribir();
		
	}

    void Escribir() {
		
        puntajeGanado = (int)puntajeGanado;
        textoDePuntaje.text = "Score: " + puntajeGanado;


    }



}
