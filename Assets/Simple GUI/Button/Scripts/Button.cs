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
using System.Collections.Generic;

public abstract class Button : MonoBehaviour {
    public Texture buttonTextureNormal;

    protected List<IButtonListener> buttonListeners = new List<IButtonListener>();

    void Start() {
        this.GetComponent<GUITexture>().texture = buttonTextureNormal;
        ButtonStart();
    }

    void Update() {
        ButtonUpdate();
    }

    public void RegisterListener(IButtonListener buttonListener) {
        buttonListeners.Add(buttonListener);
    }

    public void RemoveListener(IButtonListener buttonListener) {
        buttonListeners.Remove(buttonListener);
    }
    
    protected virtual void ButtonStart() { }
    protected virtual void ButtonUpdate() { }
    protected virtual void OnButtonStateChange(int buttonPhaseId) {
        for (int i = 0; i < buttonListeners.Count; i++) {
            buttonListeners[i].OnButtonStateChange(this, buttonPhaseId);
        }
    }

    public class PhaseId{
        public static readonly int ButtonTouchBegan = 1;
        public static readonly int ButtonTouchCanceled = 2;
        public static readonly int ButtonTouchEnded = 3;
        public static readonly int ButtonTouchMoved = 4;
        public static readonly int ButtonTouchStationary = 5;
    }

}
