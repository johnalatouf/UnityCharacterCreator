/*
 * Animation script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class CamSlightRotate : MonoBehaviour {

	[SerializeField] private float rotationSpeed = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("Rot Y = " + transform.rotation.y);

		if (Input.GetKey (KeyCode.LeftArrow) && transform.rotation.y >= -0.063) {
			transform.Rotate (0, -Time.deltaTime * rotationSpeed, 0);
		}

		if (Input.GetKey (KeyCode.RightArrow) && transform.rotation.y <= 0.057) {
			transform.Rotate (0, Time.deltaTime * rotationSpeed, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow) && transform.rotation.x >= -0.063) {
			transform.Rotate (-Time.deltaTime * rotationSpeed, 0, 0);
		}
		
		if (Input.GetKey (KeyCode.DownArrow) && transform.rotation.x <= 0.057) {
			transform.Rotate (Time.deltaTime * rotationSpeed, 0, 0);
		}



	}
}
