using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour 
{

	void Update ()
	{
		if (Input.GetKey ("space"))
		{
			transform.position = new Vector3(transform.position.x,transform.position.y + 1,transform.position.z);
		}
	}
}
