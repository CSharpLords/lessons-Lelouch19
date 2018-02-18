using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour 
{
	public Transform[] objects; 
	float min = 1000;
	Transform minObj; 
	void Start () 
	{
		for(int x = 0; x < objects.Length; x ++)
		{
			float dist =  Vector3.Distance(objects[x].position, transform.position);
			if(dist < min)
			{
				minObj = objects[x];
				min = dist;

			}
		}
	}

	void Update () 
	{
		Vector3 direction  = minObj.position - transform.position;
		direction.Normalize();
		transform.Translate(direction * 5 * Time.deltaTime);
	}
}
