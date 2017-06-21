using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysController : MonoBehaviour {

	public float emenySpeed = -100f;
	public GameObject playerref;
	void Start () {
		this.GetComponent<Rigidbody2D> ().velocity = new Vector3 (emenySpeed,0,0);
	}


	void Update () {

		// Decidir si destruir enemigo fuera de pantalla. 
		if (transform.position.x <= -135.5){
			Destroy (gameObject);
			print ("Enemigo fuera de pantalla destruido");
		}


		}
	void OnCollisionEnter2D (Collision2D collision){



		if(collision.gameObject.tag == "Player"){



			playerref.GetComponent<MovimientosPlayer>().RecibirDaño(1);
			Destroy (gameObject);

		}
	}

	}


