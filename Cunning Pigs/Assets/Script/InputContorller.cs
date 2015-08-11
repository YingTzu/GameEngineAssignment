using UnityEngine;
using System.Collections;

public class InputContorller : MonoBehaviour {
	public float moveSpeed;
	public AnimationClip Up;
	public AnimationClip Down;
	public AnimationClip Left;
	public AnimationClip Right;
	public AnimationClip Idle;
	// Use this for initialization
	void Start () {
		moveSpeed = 4 * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 temp = transform.position;

		if (Input.GetKey (KeyCode.UpArrow)) {
			temp.y += moveSpeed;
			transform.position = temp;
			GetComponent<Animator>().SetInteger ("Type", 4);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			temp.y -= moveSpeed;
			transform.position = temp;
			GetComponent<Animator>().SetInteger ("Type", 3);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			temp.x -= moveSpeed;
			transform.position = temp;
			GetComponent<Animator>().SetInteger ("Type", 1);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			temp.x += moveSpeed;
			transform.position = temp;
			GetComponent<Animator>().SetInteger ("Type", 2);
		} else
			GetComponent<Animator>().SetInteger ("Type", 0);
	}
}