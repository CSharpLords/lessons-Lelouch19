using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Transform hero;

	void Update () 
	{
		transform.position = new Vector3 (transform.position.x,transform.position.y,hero.position.z); 
	}
}
