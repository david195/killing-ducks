using UnityEngine;
using System.Collections;

public class barra : MonoBehaviour {
	static float count;
	public int lado;
	public GameObject pt;
	public engrane iz;
	public engrane der;
	// Use this for initialization
	void Start () {
		count = 120;
	}
	
	// Update is called once per frame
	void Update () {
		if(count >= 120){
			count = 0;
			if(Random.Range(0,4) <= 2){
				GameObject pato = (GameObject)Instantiate (pt,this.transform.position + new Vector3 (lado * (-3.4f), 1.14f, 0f), Quaternion.identity);
				if(lado != -1)
					pato.transform.Rotate(0f,180f,0f);
			}
		}
		else
			if(Time.timeScale == 1)
				count++;
	}
}
