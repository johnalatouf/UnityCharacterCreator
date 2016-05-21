/*
 * Animation script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class PlayerFloatMovement : MonoBehaviour {
	private Animator animator;
	[SerializeField] private int backgroundMask;
	[SerializeField] float speed = 1f; //how fast the player is
	private float camRayLength = 100f;
	private Rigidbody playerRigidbody;
	private Vector3 movement; //stores movement of player
	Quaternion newRotation;
	private int layerMask = 1;
	private bool frozen = false;
	

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerRigidbody = GetComponent<Rigidbody> ();
		//playerRigidbody.freezeRotation = true;
		//playerRigidbody.interpolation = RigidbodyInterpolation.Interpolate;
	}
	
	// Update is called once per frame
	void Update () {
	


		


	}

	//moves the player around
	void Move(float x, float y, float z)
	{
		//Vector3 v3 = new Vector3(x, y, z);
		movement.Set (x, transform.position.y, z); //moves x horizontal and z vertical and 0 in y
		//gotta normalize diagonal
		movement = movement.normalized * speed * Time.deltaTime;
		
		//playerRigidbody.MovePosition (transform.position + movement);
	}
	
	void FixedUpdate () 
	{ 
		//animator.SetBool ("PlayerFloatMove", false);
		
		//the ray casts to the mouse point on the screen
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		RaycastHit wallHit;
		
		
		
		if(Physics.Raycast (camRay, out wallHit, camRayLength, layerMask)){
			//Debug.Log ("Hitting " + wallHit.collider.name);
			Vector3 playerToMouse = wallHit.point - transform.position;
			playerToMouse.y = 0.0f;

			if(wallHit.collider.tag == "Walls" && !frozen){
				newRotation = Quaternion.LookRotation (playerToMouse);
				//playerRigidbody.MoveRotation (newRotation);
			}
		}
		
		//key pressing
		if (Input.GetKey (KeyCode.UpArrow) && !frozen) {
			animator.SetBool ("PlayerFloatMove", true); //play the movement animation
			animator.SetBool ("PlayerFloatMoveBack", false);
			//Move (wallHit.point.x, wallHit.point.y, wallHit.point.z);
			//Debug.Log("Pointing at: " + wallHit.point);
			//playerRigidbody.MovePosition (transform.position + movement);

			Vector3 destination = new Vector3(wallHit.point.x, transform.position.y, wallHit.point.z);
			transform.position = Vector3.Lerp (transform.position, destination, Time.deltaTime * speed);
			//Debug.Log ("Time " + time);
			//Debug.Log ("Current delta: " + smallSize);
			//Debug.Log ("Final delta: " + rectSize);




			//Vector3 target = new Vector3(wallHit.point.x, wallHit.point.y, wallHit.point.z);
			//float step = speed * Time.deltaTime;
			//transform.position = Vector3.MoveTowards(transform.position, target, step);
		} else if (Input.GetKey (KeyCode.DownArrow) && !frozen) {
			animator.SetBool ("PlayerFloatMove", false);
			animator.SetBool ("PlayerFloatMoveBack", true);
			//Move (-wallHit.point.x, -wallHit.point.y, -wallHit.point.z);
			//playerRigidbody.MovePosition (transform.position + movement);

			Vector3 destination = new Vector3(-wallHit.point.x, transform.position.y, -wallHit.point.z);
			transform.position = Vector3.Lerp (transform.position, destination, Time.deltaTime * speed/2);

			//Vector3 target = new Vector3(-wallHit.point.x, -wallHit.point.y, -wallHit.point.z);
			//float step = speed * Time.deltaTime;
			//transform.position = Vector3.MoveTowards(transform.position, target, step);
		} else {
			animator.SetBool ("PlayerFloatMove", false);
			animator.SetBool ("PlayerFloatMoveBack", false);
			//Move (transform.position.x, transform.position.y, transform.position.z);
		}
		
		
		
		/*if (Input.GetKey (KeyCode.LeftArrow)) {
			animator.SetBool ("PlayerFloatMove", true);
		}*/
		//playerRigidbody.MovePosition (transform.position + movement);
		playerRigidbody.MoveRotation (newRotation);
		//playerRigidbody.AddForce ( playerRigidbody.velocity * -0.1f );

		//playerRigidbody.inertiaTensorRotation



		//Vector3 point = transform.TransformPoint(offset Vector3.up); 
		//playerRigidbody.AddForceAtPosition(-Physics.gravity*playerRigidbody.mass, Vector3.up); 
	}


	//set the frozen bool to stop controller movement
	public void setFrozen(bool f){
		frozen = f;
		Debug.Log ("Frozen");
	}

}
