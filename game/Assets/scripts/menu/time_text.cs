using UnityEngine;
using System.Collections;

public class time_text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string cadena;
		cadena = "Timer:\n\n";
		for (int i = 1; i<=5; i++) {
			cadena += i.ToString() + "._ ";
			if(PlayerPrefs.GetInt("time" + i.ToString()) != null)
				cadena += PlayerPrefs.GetInt("time" + i.ToString()).ToString();
			else
				cadena += 0;
			cadena += "\n";
		}
		this.guiText.text = cadena;
	}
}
