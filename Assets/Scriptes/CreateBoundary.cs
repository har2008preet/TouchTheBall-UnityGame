﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoundary : MonoBehaviour {
	BoxCollider2D topWall;
	BoxCollider2D bottomWall;
	BoxCollider2D leftWall;
	BoxCollider2D rightWall;
	public Camera mainCam = new Camera();
	// Use this for initialization
	void Start () {
		topWall = (BoxCollider2D)gameObject.AddComponent<BoxCollider2D>();
		bottomWall = (BoxCollider2D)gameObject.AddComponent<BoxCollider2D>();
		leftWall = (BoxCollider2D)gameObject.AddComponent<BoxCollider2D>();
		rightWall = (BoxCollider2D)gameObject.AddComponent<BoxCollider2D>();

		topWall.size = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3 ( 0f, Screen.height, 0f)).y + 0.5f);

		bottomWall.size = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3( 0f, 0f, 0f)).y - 0.5f);

		leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);;
		leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

		rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
		rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
