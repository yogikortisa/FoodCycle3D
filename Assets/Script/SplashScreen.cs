using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public float timer = 7;
	
	public void Update(){
		timer -= Time.deltaTime;
		if (timer > 0){
			Debug.Log(timer);
		}else {
			Application.LoadLevel(1);
		}
	}

}
