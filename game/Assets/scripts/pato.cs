using UnityEngine;
using System.Collections;

public class pato : MonoBehaviour {
	static bool stop;
	// Update is called once per frame
	void Update () {
		if (stop)
						return;
		this.transform.Translate ((-0.8f)* Time.deltaTime, 0f, 0f);
		if(!this.renderer.isVisible)
			Destroy(this.gameObject);
	}

}
