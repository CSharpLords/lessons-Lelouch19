using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeMenishe : MonoBehaviour 
{
	public Text ageField;
	void Start () 
	{
		Button plus = GetComponent<Button> (); 
		plus.onClick.AddListener (Increase);
	}
	void Increase()
	{
		AgeBolishe.age = AgeBolishe.age - 1;
		ageField.text = AgeBolishe.age.ToString() ;
	}

}
