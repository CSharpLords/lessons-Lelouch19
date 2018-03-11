using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Melnitsa : MonoBehaviour 
{
	bool rotation = true;
	public Transform palka;
	public Button startButton;

	void Start()
	{
		startButton.onClick.AddListener(Round);
	}
	void Update()
	{
		if (rotation == true)
		{
			palka.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
		}
	}
    void Round() 
	{
		if(rotation == true)
		{
			rotation = false;
		}
		else
		{
			rotation = true;
		}
	}

}
