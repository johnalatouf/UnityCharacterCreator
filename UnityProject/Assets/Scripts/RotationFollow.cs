/*
 * Animation script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class RotationFollow : MonoBehaviour {
	private float speed = 5.0f;
	private float rotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rotation = Input.GetAxis("Horizontal") * speed;
		transform.Rotate(0,rotation,0);
	}
}
