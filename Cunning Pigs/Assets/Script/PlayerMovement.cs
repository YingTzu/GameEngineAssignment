using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 0.5f;

	public void moveUp()
	{
		Vector2 temp = transform.position;
		temp.y += moveSpeed;
		transform.position = temp;
	}
	public void moveDown()
	{
		Vector2 temp = transform.position;
		temp.y -= moveSpeed;
		transform.position = temp;
	}
	public void moveLeft()
	{
		Vector2 temp = transform.position;
		temp.x -= moveSpeed;
		transform.position = temp;
	}
	public void moveRight()
	{
		Vector2 temp = transform.position;
		temp.x += moveSpeed;
		transform.position = temp;
	}
}
