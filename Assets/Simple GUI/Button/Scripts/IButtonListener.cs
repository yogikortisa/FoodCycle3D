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

public interface IButtonListener  {
    void OnButtonStateChange(Button changedButton, int buttonPhaseId);
}
