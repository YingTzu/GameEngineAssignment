using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 0.5f;
	public AnimationClip Up;
	public AnimationClip Down;
	public AnimationClip Left;
	public AnimationClip Right;
	public Animator PlayerAnimation;
	
	public void moveUp()
	{
		Vector2 temp = transform.position;
		temp.y += moveSpeed;
		transform.position = temp;
		//PlayerAnimation.Play (Up.name);
		PlayerAnimation.SetInteger ("Type", 4);
	}
	public void moveDown()
	{
		Vector2 temp = transform.position;
		temp.y -= moveSpeed;
		transform.position = temp;
		//PlayerAnimation.Play (Down.name);
		PlayerAnimation.SetInteger ("Type", 3);
	}
	public void moveLeft()
	{
		Vector2 temp = transform.position;
		temp.x -= moveSpeed;
		transform.position = temp;
		//PlayerAnimation.Play (Left.name);
		PlayerAnimation.SetInteger ("Type", 1);
	}
	public void moveRight()
	{
		Vector2 temp = transform.position;
		temp.x += moveSpeed;
		transform.position = temp;
		//PlayerAnimation.Play (Right.name);
		PlayerAnimation.SetInteger ("Type", 2);
	}
}
