using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStolknovenie : MonoBehaviour {

	void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "Obstacle")
		{
		Destroy (gameObject);
		}
	}
}
