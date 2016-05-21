/*
 * Player Customization script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class SwapTexture : MonoBehaviour {

	[SerializeField] private Texture texture; //the texture to swap
	[SerializeField] private Texture faceTexture;
	[SerializeField] private SkinnedMeshRenderer meshRend; //the material to swap on
	[SerializeField] private SkinnedMeshRenderer faceRend;

	public void onButtonClick(){
		Debug.Log ("You clicked me!");
		meshRend.sharedMaterial.mainTexture = texture;
		faceRend.sharedMaterials[1].mainTexture = faceTexture;
	}
}
