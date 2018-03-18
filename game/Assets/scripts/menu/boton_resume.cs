using UnityEngine;
using System.Collections;

public class boton_resume : MonoBehaviour {
	public level reset;
	public level exit;
	// Use this for initialization
	void Update(){
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && this.guiTexture.HitTest(Input.GetTouch(0).position)){
			this.transform.position = new Vector3(0.5f,0.60f,0f);
			reset.transform.position = new Vector3(0.5f,0.80f,0f);
			exit.transform.position = new Vector3(0.5f,1f,0f);
			Time.timeScale = 1f;
			Time.fixedDeltaTime = 1f;
		}
	}
}
