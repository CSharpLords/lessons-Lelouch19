using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight3 : MonoBehaviour
{
	float time = 0;
	Renderer go;
	void Start()
	{
		go = GetComponent<Renderer>();
	}
	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds = (int)time;
		if (seconds == 10) 
		{
			time = 0;
		}
		else if(seconds > 8)
		{
			go.material.color = Color.green;
		}
		else if(seconds > 0)
		{
			go.material.color = Color.white;
		}
	}
}
