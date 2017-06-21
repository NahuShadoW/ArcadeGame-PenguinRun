using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorController : MonoBehaviour {

	public GameObject enemyPrefab;
	public float generatorTimer = 5f;


	void Start () {
		InvokeRepeating ("createEnemy", 0f, generatorTimer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void createEnemy(){
	
		Instantiate(enemyPrefab, transform.position, Quaternion.identity);
	
	}
}
