using UnityEngine;
using System.Collections;

public class ButtonPerAdd : MonoBehaviour {

	[Header("Personality Points")]
	[SerializeField] private int friendlyPoints = 0;
	[SerializeField] private int hostilePoints = 0;
	[SerializeField] private int professionalPoints = 0;

	[Header("Friendship Points")]
	[SerializeField] private int friendNoah = 0;

	private VariableHolder IDNumbers; //holds the player info

	//personality points
	private int perF = 0; //friendly
	private int perH = 0; //hostile
	private int perP = 0; //professional
	

	//add points to the variable holder if it exists
	public void addPoints() {
		if (GameObject.FindGameObjectWithTag ("PlayerIDs") != null) {
			IDNumbers = GameObject.FindGameObjectWithTag ("PlayerIDs").GetComponent<VariableHolder> ();
			IDNumbers.addPerF(friendlyPoints);
			IDNumbers.addPerH(hostilePoints);
			IDNumbers.addPerP(professionalPoints);
			Debug.Log ("The Current Personality: " + IDNumbers.getPerF() + ", " + IDNumbers.getPerH() + ", " + IDNumbers.getPerP()); 

			//add the friend points
			IDNumbers.addFriNoah(friendNoah);
		}
	}

}
