/*
 * Player Customization script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class SwapEyeTexture : MonoBehaviour {

	[SerializeField] private Texture texture; //the texture to swap
	[SerializeField] private SkinnedMeshRenderer meshRender; //the material to swap on
	
	public void onButtonClick(){
		meshRender.sharedMaterial.mainTexture = texture;
	}
}
