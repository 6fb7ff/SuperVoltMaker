using UnityEngine;

public class WeatherForecastDialogTest : MonoBehaviour
{
    // ダイアログを追加する親のCanvas
    [SerializeField] private Canvas parent = default;
    // 表示するダイアログ
    [SerializeField] private WeatherForecastDialog dialog = default;

    public static WeatherForecastDialogTest instance;

    public void ShowForecast()
    {
        // 生成してCanvasの子要素に設定
        var _dialog = Instantiate(dialog);
        _dialog.transform.SetParent(parent.transform, false);
        // ボタンが押されたときのイベント処理
        _dialog.FixDialog = result => Debug.Log(result);
    }
}