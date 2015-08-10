using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wavePoint : MonoBehaviour {
	public Transform[] wayPoints;
	public float moveSpeed;
	private int currentPoint;
	private int lastPoint;
	public Vector3 target;
	public Vector3 moveDirection;

	public bool moveBack;

	public Image ResetOptions;
	public Image KillButton;
	public Image SpareButton;

	private GameObject pigPop;


	void Start ()
	{
		pigPop = GameObject.Find ("PigPop");
		ResetOptions.enabled = false;
		KillButton.enabled = false;
		SpareButton.enabled = false;

		moveSpeed = 2;
		transform.position = wayPoints [0].position;
		currentPoint = 0;
		moveBack = false;
	}

	void Update()
	{
		if (transform.position == wayPoints [currentPoint].position && moveBack == false) {
			currentPoint++;
		}
		if (currentPoint >= wayPoints.Length)
		{	
			moveBack = true;
			currentPoint = wayPoints.Length-2;
		}
		if (transform.position == wayPoints [currentPoint].position && moveBack == true) 
		{
			currentPoint--;
			if(currentPoint < 0)
			{
				currentPoint = 0;
				moveBack = false;
			}
		}
		transform.position = Vector2.MoveTowards (transform.position, wayPoints [currentPoint].position, moveSpeed * Time.deltaTime);
		CheckDirection ();
	}

	void CheckDirection()
	{
		target = wayPoints[currentPoint].position;
		moveDirection = target - transform.position;

		if (moveDirection.y > 0) {
			if (GameObject.FindWithTag ("pig1")) {
				GetComponent<Animator> ().SetInteger ("pigType", 4);
			} else if (GameObject.FindWithTag ("pig2")) {
				GetComponent<Animator> ().SetInteger ("pig2Type", 4);
			}else if (GameObject.FindWithTag ("pig3")) {
				GetComponent<Animator> ().SetInteger ("pig3Type", 4);
			}
		}
		if (moveDirection.y < 0) {
			if (GameObject.FindWithTag ("pig1")) {
				GetComponent<Animator> ().SetInteger ("pigType", 3);
			} else if (GameObject.FindWithTag ("pig2")) {
				GetComponent<Animator> ().SetInteger ("pig2Type", 3);
			}else if (GameObject.FindWithTag ("pig3")) {
				GetComponent<Animator> ().SetInteger ("pig3Type", 3);
			}
		}

		if (moveDirection.x > 0) {
			if (GameObject.FindWithTag ("pig1")) {
				GetComponent<Animator> ().SetInteger ("pigType", 2);
			} else if (GameObject.FindWithTag ("pig2")) {
				GetComponent<Animator> ().SetInteger ("pig2Type", 2);
			}else if (GameObject.FindWithTag ("pig3")) {
				GetComponent<Animator> ().SetInteger ("pig3Type", 2);
			}
		}
		if (moveDirection.x < 0) {
			if (GameObject.FindWithTag ("pig1")) {
				GetComponent<Animator> ().SetInteger ("pigType", 1);
			} else if (GameObject.FindWithTag ("pig2")) {
				GetComponent<Animator> ().SetInteger ("pig2Type", 1);
			}else if (GameObject.FindWithTag ("pig3")) {
				GetComponent<Animator> ().SetInteger ("pig3Type", 1);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			moveSpeed = 0;
			ResetOptions.enabled = true;
			KillButton.enabled = true;
			SpareButton.enabled = true;
		}
	}

	public void killButton()
	{
		//pig die
		Destroy (this.gameObject);
		ResetOptions.enabled = false;
		KillButton.enabled = false;
		SpareButton.enabled = false;
	}
	
	public void spareButton()
	{
		ResetOptions.enabled = false;
		KillButton.enabled = false;
		SpareButton.enabled = false;
	}
}
