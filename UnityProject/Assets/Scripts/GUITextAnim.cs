/*
 * UI script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUITextAnim : MonoBehaviour {

	private Color col;

	// Use this for initialization
	void Start () {
		col = GetComponent<Text> ().color;
		col.a = 0.0f;
		Debug.Log ("COLOR " + col);
		Debug.Log ("Start Alpha " + col.a);
	}
	
	// Update is called once per frame
	void Update () {
		if (col.a < 1.0f) {
			col.a += 0.05f;
		}
		Debug.Log ("COLOR " + col);
	}
}
