using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class High : MonoBehaviour 
{
	double maxHigh = 0;	
	double minHigh = 1000000;
	void Update () 
	{
		if(transform.position.y > maxHigh)
		{
			print ("Максимальная высота " + maxHigh);
			maxHigh = transform.position.y;
		}
		if(transform.position.y < minHigh)
		{
			print ("Минимальная высота " + minHigh);
			minHigh = transform.position.y;
		}
	}
}
