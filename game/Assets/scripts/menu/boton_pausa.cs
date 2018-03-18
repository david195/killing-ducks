using UnityEngine;
using System.Collections;

public class boton_pausa : MonoBehaviour {
	static bool pausa;
	public boton_resume resume;
	public level reset;
	public level exit;

	void Start(){
		pausa = false;
	}
	// Use this for initialization
	void Update(){
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && this.guiTexture.HitTest(Input.GetTouch(0).position))
			pausar();
	}
	public void pausar(){
		pausa = !pausa;
		if(pausa){
			Time.timeScale = 0f;
			Time.fixedDeltaTime = 0f;
			meter();
		}
		else{
			Time.timeScale = 1f;
			Time.fixedDeltaTime = 1f;
		}
	}
	void meter(){
			resume.transform.position = new Vector3(0f,1f,0f);
			reset.transform.position = new Vector3(0f,-0.5f,0f);
			exit.transform.position = new Vector3(0f,-2f,0f);
	}
}
