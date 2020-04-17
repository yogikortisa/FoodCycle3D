using UnityEngine;
using System.Collections;

public class BackHome : MonoBehaviour {
	public Texture home;
	// Use this for initialization
	void Start () {
		// Button Kembali ke HOME
		if (GUI.Button (new Rect (-50, 90, 200, 200), home)) {
		}
	}

	void OnMouseDown () {

		Application.LoadLevel("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
