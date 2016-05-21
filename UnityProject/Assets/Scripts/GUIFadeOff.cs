/*
 * UI script from The Ceresian project
 * Created by Johna Latouf 2015-2016
 * 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIFadeOff : MonoBehaviour {

	[SerializeField] private float speed = 5.0f;
	[SerializeField] private Image arrow;
	
	private Image panelImage; //holds the image component

	// Use this for initialization
	void Start () {
		panelImage = GetComponent<Image> ();
		panelImage.canvasRenderer.SetAlpha( 0.4f ); //start the alpha at 0. For some reason, you have to do this in script
		//otherwise, the crossfade won't work
		arrow.canvasRenderer.SetAlpha( 0.4f );
		panelImage.CrossFadeAlpha (0.0f, 0.8f, false); //crossfade to .4 alpha
		arrow.CrossFadeAlpha (0.0f, 0.8f, false); //crossfade to .4 alpha
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
