using UnityEngine;
using System.Collections;

public class ShootStrawBall : MonoBehaviour 
{
	public float attackTime;
	public float coolDown;
	public float speed;
	public GameObject strawBall;

	public static Vector2 direction;

	void Start () {
		attackTime = 0;
		coolDown = 20.0f;
		speed = 5.0f;

		GetComponent<Rigidbody2D>().velocity = new Vector2(speed,0);
	}

	void Update () {
		if(attackTime > 0)
			attackTime -= Time.deltaTime;
		
		if(attackTime < 0)
			attackTime = 0;

		if(attackTime == 0) {
			Attack();
			attackTime = coolDown;
		}
		//direction = wavePoint.MoveDirection;
	}

	private void Attack() {
		Instantiate (strawBall, transform.position, Quaternion.identity);
		Vector2 temp = transform.position;
		temp.x += speed;
		strawBall.transform.position = temp;

		//instantiatedStrawBall.velocity = new Vector2 (transform.position.x + speed, 0);
			//strawBall.transform.Translate(Vector3.forward *Time.deltaTime);
		}
}