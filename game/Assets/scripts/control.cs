using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public Texture boton;
	public mira jg;
	public level reset;
	public level exit;
	public GUIText nr;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	public void parar(){
		Time.timeScale = 0f;
		Time.fixedDeltaTime = 0f;
		int i;
		for (i=1; PlayerPrefs.GetInt("time"+i.ToString())!=null && PlayerPrefs.GetInt("time"+i.ToString()) > jg.SetScore(); i++);
		if(i<6){
			PlayerPrefs.SetInt("time"+i.ToString(),jg.SetScore());
			nr.guiText.text = nr.guiText.text + "\n" + i.ToString();
			nr.transform.position = new Vector3(0f,0.2f,0f);
		}
		reset.transform.position = new Vector3(0f,-0.5f,0f);
		exit.transform.position = new Vector3(0f,-2f,0f);
	}
}
