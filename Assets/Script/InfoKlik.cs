using UnityEngine;
using System.Collections;

public class InfoKlik : MonoBehaviour {

	public Transform target1;
	public Texture gambar1,gambar2;
	public string info1,info2;
	public Vector2 scrollPosition1 = Vector2.zero;
	public bool show=false;
	//UPDATE
	public Texture exit;

	void Update(){
		if(Input.GetMouseButton(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit)){
				if(hit.transform == target1){
					show=true;
				}
			}
		}
	}

	void OnGUI(){
		if(show==true){//jika objek ditekan maka slideshow akan muncul pada layar
			//GUI.BeginGroup(new Rect(Screen.width/2-200,Screen.height/2-250,800,500));
			GUI.BeginGroup(new Rect(0,0,800,500));
			GUI.Box(new Rect(0,50,405,360),"Informasi");

			//UPDATE
			//tambahkan texture (icon exit) pada project
			//tambahkan baris berikut
			if(GUI.Button(new Rect(0, 50, 30, 30),exit)){	
				show = false; // jika tombol exit ditekan slideshow akan hilang dari layar
			}


			scrollPosition1 = GUI.BeginScrollView(new Rect(30,0,350,390),scrollPosition1,new Rect(0,0,1150,200));

			GUI.DrawTexture(new Rect(0,90,350,210),gambar1);
			info1 = GUI.TextArea(new Rect(0,300,350,50),info1,200);

			GUI.DrawTexture(new Rect(400,90,350,210),gambar2);
			info2 = GUI.TextArea(new Rect(400,300,350,50),info2,200);

			GUI.EndScrollView();
			GUI.EndGroup();

		}
	}
}
