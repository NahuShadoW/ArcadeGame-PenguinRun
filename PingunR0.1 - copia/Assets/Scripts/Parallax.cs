using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour {

	public float parallaxSpeed = 0.2f;
	public RawImage bg;
	public RawImage bg2;
	 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		bg.uvRect = new Rect (bg.uvRect.x + finalSpeed, 0f, 1f, 1f);
		bg2.uvRect = new Rect (bg2.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
	}
}
