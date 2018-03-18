using UnityEngine;
using System.Collections;

public class mira : MonoBehaviour {
	// Update is called once per frame
	static int score;
	public GUIText sc;
	void Start () {
	}

	void Update () {
		if(Time.timeScale == 0)
			return;
		float x = ((Input.acceleration.x)/2 + this.transform.position.x);
		float y = ((Input.acceleration.y)/2 + this.transform.position.y);
		if(x>2.65)
			x=2.65f;
		else{
			if(x<-2.6)
				x=-2.6f;
		}
		if(y>3.85)
			y=3.85f;
		else{
			if(y<-4.62)
				y=-4.62f;
		}
		this.transform.position = new Vector3 (x, y, 0f);
	}
	void OnTriggerStay2D(Collider2D c){
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			Destroy (c.gameObject);
			score++;
			sc.guiText.text = "Score: " + score.ToString();
		}
	}
	public int SetScore(){
		return score;
	}
}
