using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Script : MonoBehaviour 
{

	float time = 0;
	void Start () 
	{
	}

	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds =  (int)time;
		print ("Кол-во секунд - " + seconds);
	}
}