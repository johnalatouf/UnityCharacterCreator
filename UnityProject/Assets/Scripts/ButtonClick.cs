/*
 * UI script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnRightPointerClick(PointerEventData data)
	{
		Debug.Log("Right-click "+gameObject.name);
	}
}
