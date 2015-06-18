//using UnityEngine;
//using System.Collections;
//
//public class PigMovement : MonoBehaviour {
//
//	public FullGameManager fullgamemanager;
//
//	float StartPos;
//	float EndPos;
//
//	public int Units = 2;
//	public float moveSpeed = 0.1f;
//
//	float pos_Y;
//	bool moveUp = true;
//
//	void Awake()
//	{
//		pos_Y = 0;
//
//		StartPos = transform.position.x;
//		EndPos = StartPos + Units;
//	}
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		this.transform.Translate(new Vector2 (0, pos_Y));
//
//		if (moveUp) {
//			//rigidbody.Velocity.x += Vector2.up*moveSpeed*Time.deltaTime;
//			//GetComponent<Rigidbody>().position += Vector2.up*moveSpeed*Time.deltaTime;
//			pos_Y += moveSpeed;
//		} else
//			pos_Y -= moveSpeed;
//		//if (transform.position = EndPos) {
//		//	moveUp = false;
//		//}
//	}
//
//	void OnCollisionEnter (Collision collision)
//	{
//		if (moveUp)
//			moveUp = false;
//		else
//			moveUp = true;
//	}
//}
