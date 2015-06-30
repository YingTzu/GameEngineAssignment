using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 0.01f; 

	private bool walkUp;
	private bool walkLeft;
	private bool walkRight;
	private bool walkDown;

//	public void moveUp()
//	{
//		Vector2 temp = transform.position;
//		temp.y += moveSpeed;
//		transform.position = temp;
//		//PlayerAnimation.Play (Up.name);
//		GetComponent<Animator> ().SetInteger ("Type", 4);
//	}
//	public void moveDown()
//	{
//		Vector2 temp = transform.position;
//		temp.y -= moveSpeed;
//		transform.position = temp;
//		GetComponent<Animator>().SetInteger ("Type", 3);
//	}
//	public void moveLeft()
//	{
//		Vector2 temp = transform.position;
//		temp.x -= moveSpeed;
//		transform.position = temp;
//		GetComponent<Animator>().SetInteger ("Type", 1);
//	}
//	public void moveRight()
//	{
//		Vector2 temp = transform.position;
//		temp.x += moveSpeed;
//		transform.position = temp;
//		GetComponent<Animator>().SetInteger ("Type", 2);
//	}
//	void Update () {
//
//	}

	public void Update()
	{
		if (walkUp) {
			Vector2 temp = transform.position;
			temp.y += 0.01f;
			transform.position = temp;
			//GetComponent<Rigidbody2D> ().AddForce (Vector2.up * moveSpeed);
			GetComponent<Animator> ().SetInteger ("Type", 4);
		} else if (walkLeft) {
			Vector2 temp = transform.position;
			temp.x -= 0.01f;
			transform.position = temp;
			//GetComponent<Rigidbody2D> ().AddForce (-Vector2.right * moveSpeed);
			GetComponent<Animator> ().SetInteger ("Type", 1);
		} else if (walkRight) {
			Vector2 temp = transform.position;
					temp.x += 0.01f;
					transform.position = temp;
//			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * moveSpeed);
			GetComponent<Animator> ().SetInteger ("Type", 2);
		} else if (walkDown) {
			Vector2 temp = transform.position;
					temp.y -= 0.01f;
					transform.position = temp;
//			GetComponent<Rigidbody2D> ().AddForce (-Vector2.up * moveSpeed);
			GetComponent<Animator> ().SetInteger ("Type", 3);
		} else {
		}
	}
	public void PlayerWalkUp(int value){
		if (value == 1)
		{
			walkUp = true;
		}
		else
		{
			walkUp = false;
		}
	}
	
	public void PlayerWalkLeft(int value){
		if (value == 1)
		{
			walkLeft = true;
		}
		else
		{
			walkLeft = false;
		}
	}
	
	public void PlayerWalkRight(int value){
		if (value == 1)
		{
			walkRight = true;
		}
		else
		{
			walkRight = false;
		}
	}
	
	public void PlayerWalkDown(int value){
		if (value == 1)
		{
			walkDown = true;
		}
		else
		{
			walkDown = false;
		}
	}
}
