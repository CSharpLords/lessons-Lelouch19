using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeBolishe : MonoBehaviour 
{
	public Text ageField;
	public static int age = 0;
	void Start () 
	{
		Button plus = GetComponent<Button> (); 
		plus.onClick.AddListener(Increase);
	}
	void Increase()
	{
		age = age + 1;
		ageField.text = age.ToString();
	}
}