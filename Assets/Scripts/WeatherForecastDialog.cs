using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeatherForecastDialog : MonoBehaviour
{
    public enum DialogResult
    {
        OK,
    }
    
    // ダイアログが操作されたときに発生するイベント
    public Action<DialogResult> FixDialog { get; set; }

    
    // Cancelボタンが押されたとき
    public void WeatherOnOk()
    {
        // イベント通知先があれば通知してダイアログを破棄してしまう
        this.FixDialog?.Invoke(DialogResult.OK);
        Destroy(this.gameObject);
    } 
}