/**  
 * Author   : Ahmad Saifuddin Azhar
 * Email    : saifuddinazhar@gmail.com
 * Website  : duniadigit.blogspot.com
 * 
 * Asset ini bebas dipakai, dimodifikasi dan disebar luaskan dengan tidak menghapus bagian ini
 * DILARANG memperjual belikan asset ini tanpa izin author
 * 
 * Laporan saran, kritik, dan bug dapat disampaikan melalui email saifuddinazhar@gmail.com
 */

using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour, IButtonListener {
    public GameObject[] cubes;

    private Button buttonPlay, buttonInfo, buttonExit;
    private GUIText buttonStatus;

	void Start () {
        buttonPlay = this.transform.FindChild("Button Play").GetComponent<Button>();
        buttonInfo = this.transform.FindChild("Button Info").GetComponent<Button>();
        buttonExit = this.transform.FindChild("Button Exit").GetComponent<Button>();
        buttonStatus = this.transform.FindChild("Button Status").GetComponent<GUIText>();

        buttonPlay.RegisterListener(this);
        buttonInfo.RegisterListener(this);
        buttonExit.RegisterListener(this);
	}

    public void OnButtonStateChange(Button changedButton, int buttonPhaseId) {
        if (buttonPhaseId == Button.PhaseId.ButtonTouchBegan) {
            buttonStatus.text = changedButton.name + " : " + "mulai sentuhan";
            Debug.Log(changedButton.name + " : " + "mulai sentuhan");
        } else if (buttonPhaseId == Button.PhaseId.ButtonTouchEnded) {
            buttonStatus.text = changedButton.name + " : " + "akhir sentuhan";
            Debug.Log(changedButton.name + " : " + "akhir sentuhan");
        } else if (buttonPhaseId == Button.PhaseId.ButtonTouchCanceled) {
            buttonStatus.text = changedButton.name + " : " + "sentuhan dibatalkan";
            Debug.Log(changedButton.name + " : " + "sentuhan dibatalkan");
        } else if (buttonPhaseId == Button.PhaseId.ButtonTouchStationary || buttonPhaseId == Button.PhaseId.ButtonTouchMoved) {
            foreach(GameObject cube in cubes){
                cube.transform.Rotate(Vector3.back * 100 * Time.deltaTime);
            }
            Debug.Log(changedButton.name + " " + "sentuhan ditahan");
        }
    }
}
