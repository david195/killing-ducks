using UnityEngine;
using System.Collections;

public class nube : MonoBehaviour {
	public float vel;
	
	// Update is called once per frame
	void Update () {
		if(this.renderer.isVisible)
			this.transform.position += new Vector3(vel,0f,0f);
		else
			vel = vel * (-1);
	}
}
