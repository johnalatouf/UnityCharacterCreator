/*
 * Animation script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class CameraRotatesWithPlayer : MonoBehaviour {

	[SerializeField] private GameObject playerModel;
	[SerializeField] private float speed = 6.0f;
	[SerializeField] private Vector3 offset; //offset from model
	//private Rigidbody cameraRigidbody;
	
	// Use this for initialization
	void Start () {
		//cameraRigidbody = GetComponent<Rigidbody> ();
	}
	
	void Update () {

		//transform.LookAt(playerModel.transform.position);
		
	

		//Vector3 playerToMouse = playerModel.transform.position - transform.position - offset;
		//transform.LookAt(playerToMouse);
		//Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
		//cameraRigidbody.MoveRotation (newRotation);
		//transform.position = playerModel.transform.position + offset;


		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.RotateAround (playerModel.transform.position, new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * speed);
			//transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			//transform.Rotate(Vector3.down * Time.deltaTime * speed, Space.World);
			transform.RotateAround (playerModel.transform.position, new Vector3(0.0f,-1.0f,0.0f),20 * Time.deltaTime * speed);
		}
		
		
	}
}
