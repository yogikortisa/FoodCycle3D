using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour, IButtonListener {
/*
	//variable button
	private Button buttonStart, buttonAnimasi, buttonAbout, buttonExit;

	//variable untuk mendaftarkan gambar tombol exit
	public Texture exit;

	void Start () {
		buttonStart = this.transform.FindChild("buttonStart").GetComponent<Button>();
		buttonAnimasi = this.transform.FindChild("buttonAnimasi").GetComponent<Button>();
		buttonAbout = this.transform.FindChild("buttonAbout").GetComponent<Button>();
		buttonExit = this.transform.FindChild("buttonExit").GetComponent<Button>();
		buttonHome = this.transform.FindChild("buttonHome").GetComponent<Button>();
		
		buttonStart.RegisterListener(this);
		buttonAnimasi.RegisterListener(this);
		buttonAbout.RegisterListener(this);
		buttonExit.RegisterListener(this);
		buttonHome.RegisterListener(this);
	}

	public void OnButtonStateChange(Button changedButton, int buttonPhaseId) {
		if (changedButton == buttonStart) { // jika button touch di tekan
			Application.LoadLevel(2); // pindah ke scene 2 (Menu Augmented Reality Zoo)
		}
		
		if (changedButton == buttonAnimasi) { // jika Animasi ditekan
			Application.LoadLevel(3); // slideshow panduan ditampilkan 
		}

		if (changedButton == buttonAbout) {
			Application.LoadLevel(4);
		}

		if (changedButton == buttonExit) {
			Application.Quit(); // keluar dari aplikasi
		}

		if (changedButton == buttonHome) {
			Application.LoadLevel(1); // keluar dari aplikasi
		}
	}
*/


	//variable button
	private Button buttonStart, buttonAnimasi, buttonAbout, buttonExit;
	//variable untuk memberikan status apakah button sedang ditekan (true) atau tidak ditekan (false)
	public Texture gambar1,gambar2,gambar3;
	//variable untuk menambahkan text pada slide show yang dibagi menjadi beberapa bagian (info1,2,3)
	public string info1,info2,info3;
	//variable untuk memberikan status aplikasi apakah sedang aktif(true) atau quit (false)
	public bool menuAbout = false;
	//variable untuk mendaftarkan gambar tombol exit
	public Texture exit;
	//script untuk slideshow
	public Vector2 scrollPosition1 = Vector2.zero;
	public GUISkin guiSkin;
	
	void Start () {
		buttonStart = this.transform.FindChild("buttonStart").GetComponent<Button>();
		buttonAnimasi = this.transform.FindChild("buttonAnimasi").GetComponent<Button>();
		buttonAbout = this.transform.FindChild("buttonAbout").GetComponent<Button>();
		buttonExit = this.transform.FindChild("buttonExit").GetComponent<Button>();
		
		buttonStart.RegisterListener(this);
		buttonAnimasi.RegisterListener(this);
		buttonAbout.RegisterListener(this);
		buttonExit.RegisterListener(this);
	}
	
	public void OnButtonStateChange(Button changedButton, int buttonPhaseId) {
		if (changedButton == buttonStart) { // jika button touch di tekan
			Application.LoadLevel(2); // pindah ke scene 2 
		}

		if (changedButton == buttonAnimasi) { // jika Animasi ditekan
			Application.LoadLevel(3); // slideshow panduan ditampilkan 
		}

		if(changedButton == buttonAbout) { // jika panduan ditekan
			Application.LoadLevel(4);//menuAbout=true; // slideshow panduan ditampilkan 
		}

		if (changedButton == buttonExit) {
			Application.Quit(); // keluar dari aplikasi
		}
	}
	
	void OnGUI(){
		if(menuAbout==true){
			
			//membentuk slideshow aplikasi
			GUI.BeginGroup(new Rect(Screen.width/2-100,Screen.height/2-150,800,500));
			//GUI.Box(new Rect(0,50,405,360),"Informasi");
			GUI.Box(new Rect(0,75,405,360),"Informasi");
			
			if(GUI.Button(new Rect(0, 50, 30, 30),exit)){	
				menuAbout = false; // jika tombol exit ditekan slideshow akan keluar
			}
			
			scrollPosition1 = GUI.BeginScrollView(new Rect(30,0,350,390),scrollPosition1,new Rect(0,0,1150,200));
			
			GUI.DrawTexture(new Rect(0,90,350,210),gambar1); // menampilkan gambar pada slideshow
			info1 = GUI.TextArea(new Rect(0,300,350,50),info1,200); // menampilkan informasi pada slideshow
			
			GUI.DrawTexture(new Rect(400,90,350,210),gambar2);
			info2 = GUI.TextArea(new Rect(400,300,350,50),info2,200);
			
			GUI.DrawTexture(new Rect(800,90,350,210),gambar3);
			info3 = GUI.TextArea(new Rect(800,300,350,50),info3,200);
			
			GUI.EndScrollView();
			GUI.EndGroup();
		}
	}


}
