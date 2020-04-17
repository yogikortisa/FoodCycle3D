using UnityEngine;
using System.Collections;

//[RequireComponent (typeof (AudioSource))]

public class Play : MonoBehaviour {
/*
	void Start() {
		Handheld.PlayFullScreenMovie ("small.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}

/*	public MovieTexture movie;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
GetComponent<AudioSource>().clip = movie.audioClip;
movie.Play();
GetComponent<AudioSource>().Play();
	}
*/
/*void OnMouseDown () {
	movie.Stop();
	Application.LoadLevel("MainMenu");
}
	
	// Update is called once per frame
	void Update () {
		if(!movie.isPlaying) Application.LoadLevel("MainMenu");
	}
}*/

	void Start() {
		StartCoroutine(CoroutinePlayMovie());
	}
	
	protected IEnumerator CoroutinePlayMovie() {
		Handheld.PlayFullScreenMovie ("anim.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		//yield return new WaitForSeconds(2.0f); //Allow time for Unity to pause execution while the movie plays.
		Application.LoadLevel("MainMenu");
	}
}