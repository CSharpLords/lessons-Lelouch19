using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyPosition : MonoBehaviour 
{
	public Transform monster;
	void Start () 
	{
		float dist = Vector3.Distance(monster.position, transform.position);
		//print (enemy.position.x);	
		print(dist);
	}
}
