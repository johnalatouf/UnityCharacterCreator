/*
 * Animation script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;


public class PlayerCustomizeControls : MonoBehaviour {


	[SerializeField] private float rotationSpeed = 20.0f; //speed of rotation
	[SerializeField] private Transform neckBoneTransform;
	//private EventSystem eventSystem;

	void Start() {
		//Debug.Log ("Current angle " + neckBoneTransform.localEulerAngles);
	}


	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("Current angle " + neckBoneTransform.localEulerAngles);
		//turn the head
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(0, -Time.deltaTime*rotationSpeed, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(0, Time.deltaTime*rotationSpeed, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow) && neckBoneTransform.localEulerAngles.y>320) {
			Debug.Log ("up to angle " + neckBoneTransform.localEulerAngles);
			Vector3 startRot = neckBoneTransform.localEulerAngles;
			Vector3 endRot = new Vector3(0, 319, 0);
			Vector3 v = Vector3.Lerp (startRot, endRot, Time.deltaTime);
			Debug.Log ("Lerp: " + v.ToString () );
			//neckBoneTransform.Rotate(Vector3.Lerp (startRot, endRot, Time.deltaTime));
			neckBoneTransform.localEulerAngles = Vector3.Lerp (startRot, endRot, Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow) && neckBoneTransform.localEulerAngles.y<356) {
			Debug.Log ("down to to angle " + neckBoneTransform.localEulerAngles);
			Vector3 startRot = neckBoneTransform.localEulerAngles;
			Vector3 endRot = new Vector3(0, 355, 0);
			neckBoneTransform.localEulerAngles = Vector3.Lerp (startRot, endRot, Time.deltaTime);
		}



	}

}
