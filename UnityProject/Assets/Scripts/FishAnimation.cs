using UnityEngine;
using System.Collections;

public class FishAnimation : MonoBehaviour {
	private Animator animator;
	[SerializeField] private GameObject convoPanel;
	[SerializeField] private Transform target;
	[SerializeField] private float speed = 5.0f;
	private Quaternion start;
	private Quaternion targetAngle;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		start = transform.rotation;// start rotation.
	}
	
	// Update is called once per frame
	void Update () {
		start = transform.rotation;// start rotation.
		targetAngle = Quaternion.LookRotation (target.position - transform.position);

		if (convoPanel != null && convoPanel.activeSelf) {
			animator.SetBool("FishConvo", true);
			transform.rotation = Quaternion.Lerp(start, targetAngle, Time.deltaTime * speed);
			//transform.LookAt(target);
		} else {
			animator.SetBool("FishConvo", false);
		}
	}
}
