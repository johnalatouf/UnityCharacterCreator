/*
 * Player Customization script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class PlayerParts : MonoBehaviour {


	[SerializeField] private GameObject hair;
	[SerializeField] private GameObject head;
	[SerializeField] private GameObject eyes;
	[SerializeField] private GameObject arms;

	[SerializeField] private GameObject[] headMeshes; //holds head meshes
	[SerializeField] private GameObject[] hairMeshes; //holds hair meshes
	[SerializeField] private Texture[] skinTones; //holds skin tones
	[SerializeField] private Texture[] armTones; //hold shirt textures
	[SerializeField] private Texture[] complexions; //holds complexion textures
	[SerializeField] private Texture[] eyeColors; //holds eye textures

	//[SerializeField] private VariableHolder IDNumbers;
	private VariableHolder IDNumbers;

	private int hairID, headID, skinID, complexionID, eyeID;

	private Color hairColor;

	// Use this for initialization
	void Start () {
		setPlayerParts ();

		//hair = GameObject.FindGameObjectWithTag ("PlayerHair");
		//head = GameObject.FindGameObjectWithTag ("PlayerHead");



		/*hairID = IDNumbers.getHairID();
		headID = IDNumbers.getHeadID();
		skinID = IDNumbers.getSkinID();
		complexionID = IDNumbers.getComplexionID();
		eyeID = IDNumbers.getEyeID();*/

		//IDNumbers = GameObject.FindGameObjectWithTag ("PlayerIDs").GetComponent<VariableHolder> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Hair " + hairID + ", Head " + headID + ", skin " + skinID);
	}



	//use the ID's to set the player's parts
	public void setPlayerParts(){

		IDNumbers = GameObject.FindGameObjectWithTag ("PlayerIDs").GetComponent<VariableHolder> ();

		//set the variables
		hairID = IDNumbers.getHairID();
		headID = IDNumbers.getHeadID();
		skinID = IDNumbers.getSkinID();
		complexionID = IDNumbers.getComplexionID();
		eyeID = IDNumbers.getEyeID();
		hairColor = IDNumbers.getHairColor ();


		//set the head
		head.GetComponent<SkinnedMeshRenderer> ().sharedMesh = headMeshes [headID].GetComponent<SkinnedMeshRenderer> ().sharedMesh;
		//set the hair
		hair.GetComponent<SkinnedMeshRenderer> ().sharedMesh = hairMeshes [hairID].GetComponent<SkinnedMeshRenderer> ().sharedMesh;

		//set the skin tone
		head.GetComponent<SkinnedMeshRenderer> ().sharedMaterials [1].mainTexture = skinTones [skinID];
		arms.GetComponent<SkinnedMeshRenderer> ().sharedMaterial.mainTexture = armTones [skinID];

		//set the complexion
		head.GetComponent<SkinnedMeshRenderer>().sharedMaterials[1].SetTexture("_DetailMask", complexions[complexionID]);
		head.GetComponent<SkinnedMeshRenderer>().sharedMaterials[1].SetTexture("_DetailAlbedoMap", complexions[complexionID]);

		//set the eye texture
		eyes.GetComponent<SkinnedMeshRenderer>().sharedMaterial.mainTexture = eyeColors[eyeID];

		//set the hair color
		hair.GetComponent<SkinnedMeshRenderer> ().sharedMaterials [0].color = hairColor;
		head.GetComponent<SkinnedMeshRenderer>().sharedMaterials[0].color = hairColor;
	}
}
