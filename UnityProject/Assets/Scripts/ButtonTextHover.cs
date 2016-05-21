/*
 * UI script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class ButtonTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	[SerializeField] private Text buttonText;
	[SerializeField] private Color hoverColor;
	[SerializeField] private Color selectColor;
	private bool selected = false;
	private Color defaultColor;

	// Use this for initialization
	void Start () {
		defaultColor = buttonText.GetComponent<Text> ().color;
	}
	
	// Update is called once per frame
	void Update () {

	}

	//on select and unselect, change color of associated text
	public void Selected(){
		buttonText.GetComponent<Text> ().color = selectColor;
		selected = true;
	}
	
	public void UnSelected(){
		buttonText.GetComponent<Text> ().color = defaultColor;
		selected = false;
	}

	//on hover
	public void OnPointerEnter (PointerEventData eventData) {
		buttonText.GetComponent<Text> ().color = hoverColor;
	}

	//on exit, do either normal or selected color
	public void OnPointerExit (PointerEventData eventData) {
		if (selected) {
			buttonText.GetComponent<Text> ().color = selectColor;
		} else {
			buttonText.GetComponent<Text> ().color = defaultColor;
		}
	}
}
