using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NoahShout : MonoBehaviour {

	[SerializeField] private GameObject character;
	[SerializeField] private GameObject uiPanel;
	[SerializeField] private Text conversationText;
	private BoxCollider boxCollider;
	private Animator animator;
	private bool convoDone = false;

	// Use this for initialization
	void Start () {
		animator = character.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		Debug.Log ("Hitting some sort of thing at least");
		if(col.gameObject.name == character.name && !convoDone)
		{
			//if you hit the character
			Debug.Log ("You're hitting the collider");
			uiPanel.SetActive(true);
			DisableMove();
			convoDone = true;
		}
	}
	
	void DisableMove(){
		PlayerFloatMovement p = character.GetComponent<PlayerFloatMovement>();
		Debug.Log ("DISABLE THE MOVEMNT");
		p.setFrozen (true);
		//p.enabled = false;
		animator.SetBool ("PlayerFloatMove", false);
		animator.SetBool ("PlayerFloatMoveBack", false);
	}
	
	/*void EnableMove(){
		PlayerFloatMovement p = GetComponent (typeof(PlayerFloatMovement));
		p.enabled = true;
	}*/
	
	public void DestroyConvo(){
		Destroy (uiPanel);
	}
}
