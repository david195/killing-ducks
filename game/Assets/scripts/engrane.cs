using UnityEngine;
using System.Collections;

public class engrane : MonoBehaviour {
	// Update is called once per frame
	public float lado;
	static float rg;

	void Start () {

	}

	void Update () { 
		rg = (-180) * lado;
		this.transform.Rotate (0f, 0f, rg * Time.deltaTime);
	}
}
