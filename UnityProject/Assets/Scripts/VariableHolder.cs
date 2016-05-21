/*
 * Player Customization script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class VariableHolder : MonoBehaviour {

	private int hairID = 0;
	private int headID = 0;
	private int skinID = 0;
	private int complexionID = 0;
	private int eyeID = 0;
	private Color hairColor = Color.black;

	//personality points
	private int perF = 0; //friendly
	private int perH = 0; //hostile
	private int perP = 0; //professional

	//friendship points
	private int friNoah = 0;

	//keep this forever
	void Awake() {
		DontDestroyOnLoad(this);
	}

	//set the ID number when an item is chosen
	public void setHairID(int id){
		hairID = id;
	}
	
	public void setHeadID(int id){
		headID = id;
	}
	
	public void setSkinID(int id){
		skinID = id;
	}
	
	public void setComplexionID(int id){
		complexionID = id;
	}
	
	public void setEyeID(int id){
		eyeID = id;
	}

	public void setHairColor(GameObject button){
		//hairColor = col;
		hairColor = button.GetComponent<HairColor> ().ButtonColor;
		Debug.Log ("The hair color saved is " + hairColor.ToString ());
	}

	//get the ID number when an item is chosen
	public int getHairID(){
		return hairID;
	}
	
	public int getHeadID(){
		return headID;
	}
	
	public int getSkinID(){
		return skinID;
	}
	
	public int getComplexionID(){
		return complexionID;
	}
	
	public int getEyeID(){
		return eyeID;
	}

	public Color getHairColor(){
		return hairColor;
	}

	//getting and adding the personality points
	public void addPerF(int i){
		perF += i;
	}

	public void addPerP(int i){
		perP += i;
	}

	public void addPerH(int i){
		perH += i;
	}

	public int getPerF(){
		return perF;
	}

	public int getPerH(){
		return perH;
	}

	public int getPerP(){
		return perP;
	}

	//adding and getting friendship points
	public void addFriNoah(int i){
		friNoah += i;
	}

	public int getFriNoah(){
		return friNoah;
	}
}
