using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour {
	
	public Transform target; 

	void Start ()
	{
		
	}

	void Update () 
	{
		Vector3 direction  = target.position - transform.position;
		direction.Normalize();
		transform.Translate(direction * 5 * Time.deltaTime);
	}
}
