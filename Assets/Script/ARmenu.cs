using UnityEngine;
using System.Collections;

public class ARmenu : MonoBehaviour {
	public GUISkin guiSkin;
	public Texture Logo,zoomin,zoomout,home,keluar,putar,putar_stop;
	private bool mShowGUIButton = true;
	public Vector3 GUIsF;
	public float sWidth;
	public float guiRatio;
	public GameObject objek1,objek2,objek3,objek4,objek5; 
	public float kecepatanRotasi = 35f;
	
	bool statusRotasi = false;
	bool scaleobjek = false;
	//bool geserobjek = false;
	
	void Awake(){
		sWidth = Screen.width;
		guiRatio = sWidth/1920;
		GUIsF = new Vector3(guiRatio,guiRatio,1);
	}
	
	void Update(){
		if(statusRotasi==true){
			objek1.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek2.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek3.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek4.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek5.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);



		}

		if (scaleobjek == true) {
			objek1.transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
			objek2.transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
			objek3.transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
			objek4.transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
			objek5.transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);

		}
	}

	void OnGUI () {
		GUI.skin = guiSkin;
		//GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width - 300*GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);

		GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width - 320*GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);

		// Button Kembali ke HOME
		if (GUI.Button (new Rect (-50, 90, 200, 200), home)) {
			Application.LoadLevel (1);
		}

		if(GUI.RepeatButton(new Rect(-50,290,200,200), zoomin)) {
			objek1.transform.localScale += new Vector3(0.05F, 0.05F, 0.05F);
			objek2.transform.localScale += new Vector3(0.05F, 0.05F, 0.05F);
			objek3.transform.localScale += new Vector3(0.05F, 0.05F, 0.05F);
			objek4.transform.localScale += new Vector3(0.05F, 0.05F, 0.05F);
			objek5.transform.localScale += new Vector3(0.05F, 0.05F, 0.05F);

		}
		// Button rotasi
		if (statusRotasi == false) {
			if (GUI.Button (new Rect (-50, 490, 200, 200), putar)) {
				statusRotasi = true;
			}
		} else {
			if (GUI.Button (new Rect (-50, 490, 200, 200), putar_stop)) {
				statusRotasi = false;
			}
		}
		if(GUI.RepeatButton(new Rect(-50,690,200,200), zoomout)) {
			objek1.transform.localScale -= new Vector3(0.05F, 0, 0);
			objek1.transform.localScale -= new Vector3(0, 0.05F, 0);
			objek1.transform.localScale -= new Vector3(0, 0, 0.05F);

			objek2.transform.localScale -= new Vector3(0.05F, 0, 0);
			objek2.transform.localScale -= new Vector3(0, 0.05F, 0);
			objek2.transform.localScale -= new Vector3(0, 0, 0.05F);

			objek3.transform.localScale -= new Vector3(0.05F, 0, 0);
			objek3.transform.localScale -= new Vector3(0, 0.05F, 0);
			objek3.transform.localScale -= new Vector3(0, 0, 0.05F);

			objek4.transform.localScale -= new Vector3(0.05F, 0, 0);
			objek4.transform.localScale -= new Vector3(0, 0.05F, 0);
			objek4.transform.localScale -= new Vector3(0, 0, 0.05F);

			objek5.transform.localScale -= new Vector3(0.05F, 0, 0);
			objek5.transform.localScale -= new Vector3(0, 0.05F, 0);
			objek5.transform.localScale -= new Vector3(0, 0, 0.05F);


		}

		// Button keluar
		if(GUI.Button(new Rect(-50,890,200,200), keluar)) {
			Application.Quit();
		}
		// Membuat text coded by Sandrio Pamungkas
		//GUI.Label (new Rect (-50, 890, 300, 80), "Nama Label ");
		
		//Button logika tampil dan sembunyikan Arahkan KeTarget
		
	}
}
