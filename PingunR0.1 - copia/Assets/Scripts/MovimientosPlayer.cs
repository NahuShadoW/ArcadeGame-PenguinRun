using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosPlayer : MonoBehaviour {

	//variable para saltar
	public float alturaSalto;
	//variable para la velocidad del movimiento
	public float velocidadMovimiento;
	//permite saber que esta en el suelo
	private bool enSuelo = true;

	public Transform  comprobadorSuelo;
	public float comprobadorRadio = 0.07f;
	//permite en que capa colosionara el comprobadorSuelo
	public LayerMask mascaraSuelo;

	

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
		//Mover a la derecha , usamos tecla D
		if(Input.GetKey (KeyCode.D)) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);
		}	
		//Mover a la izquierda , usamos tecla A
		if(Input.GetKey (KeyCode.A)) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);
		}	
	}
}