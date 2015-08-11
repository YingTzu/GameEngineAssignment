using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed; 

	private bool walkUp;
	private bool walkLeft;
	private bool walkRight;
	private bool walkDown;

	public Button up;
	public Button down;
	public Button left;
	public Button right;

	public Image key;

	public bool getKey;

	void Start () {
		getKey = false;
		moveSpeed = 4 * Time.deltaTime;
		up.GetComponent<Image> ().CrossFadeAlpha (0, 1, false);
		down.GetComponent<Image> ().CrossFadeAlpha (0, 1, false);
		left.GetComponent<Image> ().CrossFadeAlpha (0, 1, false);
		right.GetComponent<Image> ().CrossFadeAlpha (0, 1, false);
	}

	public void Update()
	{
		int numberOfTouches = Input.touchCount;
		
		if(numberOfTouches > 0)
		{
			for (int i = 0; i < numberOfTouches; i++)
			{
				Touch touch = Input.GetTouch(i);
				
				if(touch.phase == TouchPhase.Began)
				{
					if(touch.tapCount >= 2)
					{
						walkUp = false;
						walkDown = false;
						walkLeft = false;
						walkRight = false;
					}

				}
			}
		}

		characterMove ();

		if (getKey == true)
			key.enabled = true;
		else
			key.enabled = false;
	}

	void characterMove()
	{
		if (walkUp) 
		{
			Vector2 temp = transform.position;
			temp.y += moveSpeed;
			transform.position = temp;
			GetComponent<Animator> ().SetInteger ("Type", 4);
		} else if (walkLeft) {
			Vector2 temp = transform.position;
			temp.x -= moveSpeed;
			transform.position = temp;
			GetComponent<Animator> ().SetInteger ("Type", 1);
		} else if (walkRight) {
			Vector2 temp = transform.position;
			temp.x += moveSpeed;
			transform.position = temp;
			GetComponent<Animator> ().SetInteger ("Type", 2);
		} else if (walkDown) {
			Vector2 temp = transform.position;
			temp.y -= moveSpeed;
			transform.position = temp;
			GetComponent<Animator> ().SetInteger ("Type", 3);
		}
		up.GetComponent<Image> ().CrossFadeAlpha (0, 0.5f, false);
		down.GetComponent<Image> ().CrossFadeAlpha (0, 0.5f, false);
		left.GetComponent<Image> ().CrossFadeAlpha (0, 0.5f, false);
		right.GetComponent<Image> ().CrossFadeAlpha (0, 0.5f, false);
	}

	public void PlayerWalkUp()
	{
		walkUp = true;
		walkDown = false;
		walkLeft = false;
		walkRight = false;
	}
	public void PlayerWalkDown()
	{
		walkUp = false;
		walkDown = true;
		walkLeft = false;
		walkRight = false;
	}
	public void PlayerWalkLeft()
	{
		walkUp = false;
		walkDown = false;
		walkLeft = true;
		walkRight = false;
			
	}
	public void PlayerWalkRight()
	{
		walkUp = false;
		walkDown = false;
		walkLeft = false;
		walkRight = true;
	}
}
