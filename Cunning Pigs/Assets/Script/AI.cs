using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public GameObject Target;
	public bool IdleLeftRight = false;
	public bool IdleUpDown = false;
	public GameObject DetectionRange;
	private bool ChaseTarget = false;
	private Vector3 originalPos;
	public float maxIdleTranslate = 0;
	private float currentIdleTranslate = 0;
	private bool Positive = false;
	private bool Reach = false;
	public Detect Detection;

	// Use this for initialization
	void Start () {
		originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		ChaseTarget = Detection.b_Detected;//get if player is detected

		if (ChaseTarget) {
			if(!Reach)
				Chase ();
		} 
		else {
			Idle (); //change later to something else maybe patrol
		}
	}
	public void targetDetected(){
		ChaseTarget = true;
	}
	public void targetLost(){
		ChaseTarget = false;
	}
	void Chase()
	{
//		Vector2 Dir = new Vector2(Target.transform.position.x-transform.position.x,Target.transform.position.y-transform.position.y);
//		Vector3 newPosition = transform.position;
//		newPosition.x += Dir.normalized.x/20;
//		newPosition.y += Dir.normalized.y/20;
//		transform.position = newPosition;

		float MovementSpeed = 1.8f;//speed of ai chasing u
		this.transform.position = Vector2.MoveTowards (this.transform.position, Target.transform.position, MovementSpeed * Time.deltaTime);
	}
	void Idle(){
		if (IdleUpDown) {
			if(originalPos.x != transform.position.x)//if not in idle range while idling
			{
				Vector2 Dir = new Vector2(originalPos.x-transform.position.x,originalPos.y-transform.position.y);//get direction to idle range
				Vector3 newPosition = transform.position;
				newPosition.x += Dir.normalized.x/20;
				newPosition.y += Dir.normalized.y/20;
				transform.position = newPosition;//move towards idle range
			}
			else{
				if(maxIdleTranslate > currentIdleTranslate)
				{
					if(Positive)
					{
						Vector3 newPosition = transform.position;
						newPosition.y += 0.05f;
						transform.position = newPosition;
						currentIdleTranslate += 0.05f;//move up
					}
					else
					{
						Vector3 newPosition = transform.position;
						newPosition.y -= 0.05f;
						transform.position = newPosition;
						currentIdleTranslate += 0.05f;// move down
					}
				}
				else
				{
					Positive = !Positive;
					currentIdleTranslate = 0;
				}
			}
		}
		if (IdleLeftRight){
			if(originalPos.y != transform.position.y)//if not in idle range while idling
			{
				Vector2 Dir = new Vector2(originalPos.x-transform.position.x,originalPos.y-transform.position.y);
				Vector3 newPosition = transform.position;
				newPosition.x += Dir.normalized.x/20;
				newPosition.y += Dir.normalized.y/20;
				transform.position = newPosition;//move towards idle range
			}
			else{
				if(maxIdleTranslate > currentIdleTranslate)
				{
					if(Positive)
					{
						Vector3 newPosition = transform.position;
						newPosition.x += 0.05f;
						transform.position = newPosition;
						currentIdleTranslate += 0.05f;// move right
					}
					else
					{
						Vector3 newPosition = transform.position;
						newPosition.x -= 0.05f;
						transform.position = newPosition;
						currentIdleTranslate += 0.05f;//move left
					}
				}
				else
				{
					Positive = !Positive;
					currentIdleTranslate = 0;
				}
			}
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player")
			Reach = true;//if reach player
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player")
			Reach = false;//if leave player
	}
}
