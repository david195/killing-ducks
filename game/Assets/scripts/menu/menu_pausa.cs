using UnityEngine;
using System.Collections;

public class menu_pausa : MonoBehaviour {
	public GUITexture seguir;
	public GUITexture reiniciar;
	public GUITexture salir;
	public control ctrl;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		if(Input.GetTouch(0).phase == TouchPhase.Began && reiniciar.guiTexture.HitTest(Input.GetTouch(0).position))
			Application.LoadLevel("time");
		if(Input.GetTouch(0).phase == TouchPhase.Began && salir.guiTexture.HitTest(Input.GetTouch(0).position))
			Application.LoadLevel("iniciar");
	}
}
