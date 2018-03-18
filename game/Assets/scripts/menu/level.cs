using UnityEngine;
using System.Collections;

public class level : MonoBehaviour {

	public string cad;

	void Update(){
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && this.guiTexture.HitTest(Input.GetTouch(0).position))
			Application.LoadLevel(cad);
	}
}
