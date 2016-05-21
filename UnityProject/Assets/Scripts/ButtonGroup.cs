/*
 * UI script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonGroup : MonoBehaviour {

	private ColorBlock colorblock;
	private Color unselectedColor;
	[SerializeField] private Color selectedColor;

	// Use this for initialization
	void Start () {
		colorblock = GetComponent<Button>().colors;
		unselectedColor = colorblock.normalColor;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Button Normal Color: " + colorblock.normalColor);
		//Debug.Log ("Highlight Color: " + colorblock.highlightedColor);
	}

	public void Selected(){
		//Debug.Log ("Button Color: " + GetComponent<Button> ().colors);

		colorblock.normalColor = selectedColor;
		//colorblock.highlightedColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		GetComponent<Button>().colors = colorblock;
	}

	public void UnSelected(){
		//Debug.Log ("Button Color: " + GetComponent<Button> ().colors);
		
		colorblock.normalColor = unselectedColor;
		//colorblock.highlightedColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		GetComponent<Button>().colors = colorblock;
	}
}
