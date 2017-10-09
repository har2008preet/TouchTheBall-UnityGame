using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb2d;
	public Camera mainCam = new Camera();

	public float rotationTime;

	private float rotation;
	private float top,bottom,left,right;
	private float tempRotation;
	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();	

		top  = mainCam.ScreenToWorldPoint (new Vector3 ( 0f, Screen.height, 0f)).y;
		bottom = mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y;
		left = mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x;
		right = mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x;

		InvokeRepeating ("randomMovement",0.2f,0.5f);

		tempRotation = 0.0f;
		//Invoke("ChangeRotation",tempRotation);
		//print (top+" "+bottom+" " +left+ " " +right);
	}

	void randomMovement(){
		rotation = Random.Range (-360.0f,360.0f);

		transform.Rotate (new Vector3(0,0,rotation));
		float moveHorizontal = Random.Range(-30.0f,30.0f);
		float moveVertical = Random.Range(-30.0f,30.0f);
		if (moveHorizontal > right) {
			moveHorizontal = right;
		}
		if (moveHorizontal < left) {
			moveHorizontal = left;
		}
		if (moveVertical> top) {
			moveVertical = top;
		}
		if (moveVertical < bottom) {
			moveVertical = bottom;
		}
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement*speed);
		tempRotation = rotationTime;
	}

	void ChangeRotation(){
		rotation = Random.Range (-360.0f,360.0f);

		transform.Rotate (new Vector3(0,0,rotation));
		float moveHorizontal = Random.Range(-30.0f,30.0f);
		float moveVertical = Random.Range(-30.0f,30.0f);
		if (moveHorizontal > right) {
			moveHorizontal = right;
		}
		if (moveHorizontal < left) {
			moveHorizontal = left;
		}
		if (moveVertical> top) {
			moveVertical = top;
		}
		if (moveVertical < bottom) {
			moveVertical = bottom;
		}
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement*speed);
		tempRotation = rotationTime;
		//transform.position += new Vector2(Random.Range(-10.0f,10.0f),Random.Range(-10.0f,10.0f));
	}

	void Update(){
		//Invoke("ChangeRotation",rotationTime);
	}

	void FixedUpdate(){
		//float moveHorizontal;
		//float moveVertical;
		//if (SystemInfo.deviceType == DeviceType.Desktop) {
		//	moveHorizontal = Input.GetAxis("Horizontal");
		//	moveVertical = Input.GetAxis("Vertical");
		//} else {
		//	moveHorizontal = Input.acceleration.x;
		//	moveVertical = Input.acceleration.y;
		//}
		//Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		//rb2d.AddForce (movement*speed);
	}

}
