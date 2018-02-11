using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour {
	float time = 0;
	Renderer stop;
	void Start()
	{
		stop = GetComponent<Renderer>();
	}
	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds = (int)time;
		if (seconds == 10) 
		{
			time = 0;
		}
		else if (seconds > 5) 
		{
			stop.material.color = Color.white;
		}
		else if (seconds < 5 || seconds == 0) 
		{
			stop.material.color = Color.red;
		} 


	}
}
