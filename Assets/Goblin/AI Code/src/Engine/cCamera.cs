using System;
using UnityEngine;

public class cCamera : Actor
{
	// ----------------------------------------------
	// CONSTANTS
	// ----------------------------------------------
	public const int STATE_IDLE    	= 0;
	
	// ----------------------------------------------
	// VARIABLE MEMBERS
	// ----------------------------------------------
	private Camera m_camera;
	private Transform m_goal;
	private float m_distance = 15f;

	// ----------------------------------------------
	// CONSTRUCTOR
	// ----------------------------------------------	
	// -------------------------------------------
	/* 
	 * Constructor
	 */
	public cCamera() 
	{
		ChangeState(STATE_IDLE);
	}
	
	// ----------------------------------------------
	// INIT/DESTROY
	// ----------------------------------------------	
	
	// -------------------------------------------
	/* 
	 * Start		
	 */
	void Start () 
	{					
	}
	
	// -------------------------------------------
	/* 
	 * Destroy		
	 */
	void Destroy () 
	{			
	}

	// ----------------------------------------------
	// GETTERS/SETTERS
	// ----------------------------------------------	
	public Camera MyCamera
    {
        get { return m_camera; }
        set { m_camera = value; }
    }
	public Transform Goal
    {
        get { return m_goal; }
        set { m_goal = value; }
    }

	// ----------------------------------------------
	// LISTENERS
	// ----------------------------------------------	
	

	// ----------------------------------------------
	// PRIVATE/PROTECTED FUNCTIONS
	// ----------------------------------------------	
	
	// ----------------------------------------------
	// PUBLIC FUNCTIONS
	// ----------------------------------------------	

	// ----------------------------------------------
	// UPDATE
	// ----------------------------------------------	
	// -------------------------------------------
	/* 
	 * Update		
	 */
	public override void Update () 
	{
		base.Update();		
		
		switch (m_state)
		{
			case STATE_IDLE:
				if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
				{
					m_distance += 2.5f;					
				}
				if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
				{
					m_distance -= 2.5f;
					if (m_distance<10) m_distance=10;
				}				
			
				Global.RotateTo(m_camera.transform, m_goal, false, false, false);
				Global.MoveToPosition(m_camera.transform, new Vector3(m_goal.transform.position.x, m_distance, m_goal.transform.position.z-m_distance));
				// Global.MoveToPosition(m_camera.transform, new Vector3(m_goal.transform.position.x,15, m_goal.transform.position.z-15));
				break;
		}		
	}
} 

