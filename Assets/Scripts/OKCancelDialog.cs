using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OKCancelDialog : MonoBehaviour
{
    public enum DialogResult
    {
        OK,
        Cancel,
    }
    
    // ダイアログが操作されたときに発生するイベント
    public Action<DialogResult> FixDialog { get; set; }
    
    // OKボタンが押されたとき
    public void OnOk()
    {
        this.FixDialog?.Invoke(DialogResult.OK);
        Destroy(this.gameObject);
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    
    // Cancelボタンが押されたとき
    public void OnCancel()
    {
        // イベント通知先があれば通知してダイアログを破棄してしまう
        this.FixDialog?.Invoke(DialogResult.Cancel);
        Destroy(this.gameObject);
    }
}