using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	static float tm;
	public mira mir;
	public barra b1;
	public barra b2;
	public barra b3;

	public control ctrl;

	void Start(){
		tm = 60;
	}

	// Update is called once per frame
	void Update () {
		
		Screen.sleepTimeout = 0;
		if(Time.timeScale == 0)
			return;
		if(tm <= 0f){
			ctrl.parar();
		}
		tm -= Time.deltaTime;
		this.guiText.text = "Time: " + ((int)tm).ToString();
	}
}
