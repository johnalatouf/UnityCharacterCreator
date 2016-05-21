/*
 * UI script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonGroupOutline : MonoBehaviour {

	private Color outlineColor;
	private Color unselectedColor;
	[SerializeField] private Color selectedColor;

	// Use this for initialization
	void Start () {
		outlineColor = GetComponent<Outline> ().effectColor;
		unselectedColor = outlineColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Selected(){
		//Debug.Log ("Button Color: " + GetComponent<Button> ().colors);
		
		outlineColor = selectedColor;
		//colorblock.highlightedColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		GetComponent<Outline> ().effectColor = outlineColor;
	}
	
	public void UnSelected(){
		//Debug.Log ("Button Color: " + GetComponent<Button> ().colors);
		
		outlineColor = unselectedColor;
		//colorblock.highlightedColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		GetComponent<Outline> ().effectColor = outlineColor;
	}
}
