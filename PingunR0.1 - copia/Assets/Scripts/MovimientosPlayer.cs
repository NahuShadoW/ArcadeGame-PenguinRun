using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosPlayer : MonoBehaviour {

	//variable que permite darle el contador d vida al player
	 int vida = 3;

	//variable para saltar
	public float alturaSalto;

	//permite saber que esta en el suelo
	private bool enSuelo = true;

	public Transform  comprobadorSuelo;

	//permite comprobar el radio
	public float comprobadorRadio = 0.07f;

	//permite en que capa colosionara el comprobadorSuelo
	public LayerMask mascaraSuelo;

	public AudioSource sonidoSalto;
	public AudioClip sonidoMuerte;

	void Start () {

	}

	void FixedUpdate(){

		//Sirve para poder hacer que el persona tenga permitido el salto solo cuando esta tocando el suelo
		enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
	
	}

	void Update () {

		//Movimiento del personaje
		//Saltar, usamos la barra espaciadora
		if(enSuelo && Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, alturaSalto);
		}

	}
		
	public void RecibirDaño (int dañoRecibido){

		if (vida != 0) {
			vida = vida - dañoRecibido;
		} 
		else if(vida == 0) {
			Muerte ();
		}

	}

	//Fin del juego
	public void Muerte(){


	}


}