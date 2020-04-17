/**  
 * Author   : Ahmad Saifuddin Azhar
 * Email    : saifuddinazhar@gmail.com
 * Website  : duniadigit.blogspot.com
 * 
 * Asset ini bebas dipakai, dimodifikasi dan disebar luaskan dengan tidak menghapus bagian ini
 * DILARANG KERAS memperjual belikan asset ini tanpa izin author
 * 
 * Laporan saran, kritik, dan bug dapat disampaikan melalui email saifuddinazhar@gmail.com
 */

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUITexture))]
public class TouchScreenButton : Button {
    public Texture buttonTextureTouched;

    private int touchFingerId = -1;

    protected override void ButtonUpdate() {
        for (int i = 0; i < Input.touchCount; i++) {
            if (this.GetComponent<GUITexture>().HitTest(Input.GetTouch(i).position)) {
                if (Input.GetTouch(i).phase == TouchPhase.Began) {
                    touchFingerId = Input.GetTouch(i).fingerId;
                    this.GetComponent<GUITexture>().texture = buttonTextureTouched;
                    OnButtonStateChange(Button.PhaseId.ButtonTouchBegan);
                } else if (Input.GetTouch(i).phase == TouchPhase.Stationary) {
                    OnButtonStateChange(Button.PhaseId.ButtonTouchStationary);
                } else if (Input.GetTouch(i).phase == TouchPhase.Moved) {
                    OnButtonStateChange(Button.PhaseId.ButtonTouchMoved);
                } else if (Input.GetTouch(i).phase == TouchPhase.Ended) {
                    this.GetComponent<GUITexture>().texture = buttonTextureNormal;
                    OnButtonStateChange(Button.PhaseId.ButtonTouchEnded);
                }
            } else {
                if (Input.GetTouch(i).fingerId == touchFingerId) {
                    touchFingerId = -1;
                    this.GetComponent<GUITexture>().texture = buttonTextureNormal;
                    OnButtonStateChange(Button.PhaseId.ButtonTouchCanceled);
                }
            }    
        }
    }
}
