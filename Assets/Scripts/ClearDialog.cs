using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDialog : MonoBehaviour
{
    public enum DialogResult
    {
        OK,
    }
    
    // ダイアログが操作されたときに発生するイベント
    public Action<DialogResult> FixDialog { get; set; }
    
    // OKボタンが押されたとき
    public void ClickOk()
    {
        this.FixDialog?.Invoke(DialogResult.OK);
        Destroy(this.gameObject);
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}