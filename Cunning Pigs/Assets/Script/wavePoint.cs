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
	
	private bool Inited = false;
	
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
		
		Vector3 PFacingDir = new Vector3 (Target.x, Target.y, 0) - transform.position;

		if (Velocity.y > 0 && Velocity.y < 0.1)
			Velocity.y = 0;
		if (Velocity.x > 0 && Velocity.x < 0.1)
			Velocity.x = 0;

		if (Velocity.y < 0 && Velocity.y > -0.1)
			Velocity.y = 0;
		if (Velocity.x < 0 && Velocity.x > -0.1)
			Velocity.x = 0;

		if (Velocity.y >= 0 && Velocity.x == 0) 
		{
			if(GameObject.Find("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 4);
			}
			else if(GameObject.Find("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 4);
			}
		}
		else if (Velocity.y <= 0 && Velocity.x == 0) 
		{
			if(GameObject.Find("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 3);
			}
			else if(GameObject.Find("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 3);
			}

		}
		if (Velocity.x >= 0 && Velocity.y == 0) 
		{
			if(GameObject.Find("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 2);
			}
			else if(GameObject.Find("pig2"))
			{
				GetComponent<Animator>().SetInteger ("pig2Type", 2);
			}
		}
		else if (Velocity.x <= 0 && Velocity.y == 0) 
		{
			if(GameObject.Find("pig1"))
			{
				GetComponent<Animator>().SetInteger ("pigType", 1);
			}
			else if(GameObject.Find("pig2"))
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

	void UpdateState() 
	{
		rTime += Time.deltaTime;
		
		if (rTime > 3 && !Inited)
		{
			u_state = state.MOVE;
			Inited = true;
			rTime = 0.0f;
		}
	}

	void Update () 
	{
		UpdateState ();
		
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
