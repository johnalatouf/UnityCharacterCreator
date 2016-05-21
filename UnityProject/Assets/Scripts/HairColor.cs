/*
 * Player Customization script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class HairColor : MonoBehaviour {

	[SerializeField] private SkinnedMeshRenderer hairMeshRender; //the material to swap on
	[SerializeField] private SkinnedMeshRenderer browMeshRender; //the material to swap on
	[SerializeField] private Color buttonColor;
	public Color ButtonColor {
		get { return buttonColor;}
	}
	private Material hairMaterial;
	private Material browMaterial;

	// Use this for initialization
	void Start () {
		browMaterial = browMeshRender.sharedMaterials [0];
		hairMaterial = hairMeshRender.sharedMaterials [0];
	}
	
	public void onButtonClick(){
		browMaterial.color = buttonColor;
		hairMaterial.color = buttonColor;
		Debug.Log (buttonColor.ToString ());
	}
}
