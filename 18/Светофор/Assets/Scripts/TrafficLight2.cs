using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight2 : MonoBehaviour 
{
	public float time = 0;
	Renderer wait;
	void Start()
	{
		wait = GetComponent<Renderer>();
	}
	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds = (int)time;
	    if (seconds == 10) 
		{
			time = 0;
		}
		else if (seconds > 8) 
		{
			wait.material.color = Color.white;
		}
		else if(seconds > 5)
		{
			wait.material.color = Color.yellow;
	
		}


	}

}
