using UnityEngine;
using System.Collections;

public class wavePoint : MonoBehaviour {
	
	public Transform[] Waypoints;
	public float m_speed;
	public int curWayPoint;
	public bool doPatrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;
	
	public float rTime;
	public float fTime = 0.0f;

	public enum state
	{
		IDLE,
		MOVE
	}; 
	public state u_state;
	
	void Start () {
		u_state = state.MOVE;
	}

	void Aggro(Vector3 tarPos)
	{
		Target = tarPos;
		MoveDirection = Target - transform.position;
		Velocity = GetComponent<Rigidbody2D>().velocity;
		Velocity = MoveDirection.normalized * m_speed;

		if (Velocity.y > 0 && Velocity.y < 0.01)
			Velocity.y = 0;
		if (Velocity.x > 0 && Velocity.x < 0.01)
			Velocity.x = 0;

		if (Velocity.y < 0 && Velocity.y > -0.01)
			Velocity.y = 0;
		if (Velocity.x < 0 && Velocity.x > -0.01)
			Velocity.x = 0;

		if (Velocity.y >= 0 && Velocity.x == 0) 
		{
			if(GameObject.FindWithTag("pig1"))
			{
				GetComponent<Animator>().SetInteger("pigType", 4);
			}
			if(GameObject.FindWithTag("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 4);
			}
		}
		else if (Velocity.y <= 0 && Velocity.x == 0) 
		{
			if(GameObject.FindWithTag("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 3);
			}
			if(GameObject.FindWithTag("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 3);
			}
		}
		if (Velocity.x >= 0 && Velocity.y == 0) 
		{
			if(GameObject.FindWithTag("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 2);
			}
			if(GameObject.FindWithTag("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 2);
			}
		}
		else if (Velocity.x <= 0 && Velocity.y == 0) 
		{
			if(GameObject.FindWithTag("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 1);
			}
			if(GameObject.FindWithTag("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 1);
			}
		}
	}

	void Freed()
	{
		fTime += Time.deltaTime;
		
		if (fTime > 10.0f)
		{
			u_state = state.MOVE;
			fTime = 0.0f;
		}
	}

	void Update () 
	{
		GetComponent<Rigidbody2D>().velocity = Velocity;
		
		switch (u_state) 
		{
			case state.MOVE:
			{
				if (curWayPoint < Waypoints.Length)
				{
					Aggro(Waypoints[curWayPoint].position);
					if (MoveDirection.magnitude < 0.1f) // reach waypoint
						curWayPoint ++;	
				}
				else
				{
					if (doPatrol)
						curWayPoint = 0;
					else
						Velocity = Vector3.zero;
				}
			}
			break;

			case state.IDLE:
			default:
				Velocity.Set(0,0,0);
				break;
			
		}
	}
}
