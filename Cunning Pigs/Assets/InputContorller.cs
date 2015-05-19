using UnityEngine;
using System.Collections;

public class InputContorller : MonoBehaviour {
	public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 temp = transform.position;
		if (Input.GetKey (KeyCode.UpArrow))
		{
			temp.y += 1;
			transform.position = temp;
		}
		else if (Input.GetKey (KeyCode.DownArrow))
		{
			temp.y -= 1;
			transform.position = temp;
		}
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			temp.x -= 1;
			transform.position = temp;
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			temp.x += 1;
			transform.position = temp;
		}

	}
}