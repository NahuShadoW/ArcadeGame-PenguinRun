using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MovimientosPlayer : MonoBehaviour {

	//variable que permite darle el contador d vida al player
	public int vida;

	//variable para saltar
	public float alturaSalto;

	//permite saber que esta en el suelo
	private bool enSuelo;

	public Transform  comprobadorSuelo;

	//permite comprobar el radio
	public float comprobadorRadio = 4f;

	//permite en que capa colosionara el comprobadorSuelo
	public LayerMask mascaraSuelo;

	public AudioSource sonidoSalto;
	public AudioSource sonidoMuerte;

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
			vida -= dañoRecibido;
			print ("Has recibido daño de Walrus!, tu vida es: " + vida);
		} 
		else if(vida <= 0) {
			Muerte ();
		}

	}

	//Fin del juego
	public void Muerte(){

		SceneManager.LoadScene("GameOverScene");
		Debug.Log("Has muerto");
		//sonidoMuerte.Play();
	}


}