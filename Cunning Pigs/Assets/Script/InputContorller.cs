using UnityEngine;
using System.Collections;

public class InputContorller : MonoBehaviour {
	public float moveSpeed = 0.05f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 temp = transform.position;
		if (Input.GetKey (KeyCode.UpArrow))
		{
			temp.y += moveSpeed;
			transform.position = temp;
		}
		else if (Input.GetKey (KeyCode.DownArrow))
		{
			temp.y -= moveSpeed;
			transform.position = temp;
		}
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			temp.x -= moveSpeed;
			transform.position = temp;
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			temp.x += moveSpeed;
			transform.position = temp;
		}
	}
}