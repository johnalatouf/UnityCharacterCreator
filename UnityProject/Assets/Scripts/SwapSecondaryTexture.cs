/*
 * Player Customization script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;

public class SwapSecondaryTexture : MonoBehaviour {

	[SerializeField] private Texture texture; //the texture to swap
	[SerializeField] private SkinnedMeshRenderer meshRend; //the material to swap on
	
	public void onButtonClick(){
		meshRend.sharedMaterials[1].SetTexture ("_DetailMask", texture);
		meshRend.sharedMaterials[1].SetTexture ("_DetailAlbedoMap", texture);
	}
}
