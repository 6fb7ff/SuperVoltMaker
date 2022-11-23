using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
Todo 
2.計算


*/



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform Hand, Ocean, Land;
    [SerializeField] Text NowTurnTxt;
    [SerializeField] Text MaxTurnTxt;
    [SerializeField] Text WeatherTxt;
    [SerializeField] Text DemandTxt;
    [SerializeField] Text SupplyTxt;
    [SerializeField] GameObject ForeCast;
    [SerializeField] GameObject End;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject Over;
    
    bool process    =false;
    int     NowTurn; // 現在ターン
    int     MaxTurn; // 最大ターン
    int     Weather_int;
    string  Weather;
    int     Demand;
    int     Supply = 200;

    void Start(){
        StartGame();
    }

    void StartGame(){ // 初期値の設定 {
        // ターンの決定
        NowTurn=1;
        MaxTurn=10;
        TurnStart();
    }

    void TurnStart(){
        if(!process){
            DrawCard(Hand);
            Weather_int = Random.Range(1, 4);
            Demand  = (Random.Range(1, 10)) * 10 + 50;// ※ 1～9の範囲でランダムな整数値が返る
            switch( Weather_int )
            {
            case 1: Weather = "晴れ"; break;
            case 2: Weather = "曇り"; break;
            case 3: Weather = "雨"; break;
            case 4: Weather = "雷"; break;
            }

            this.ForeCast.SetActive (true);
            NowTurnTxt.text = NowTurn.ToString();
            MaxTurnTxt.text = MaxTurn.ToString();
            WeatherTxt.text = Weather;
            DemandTxt.text = Demand.ToString();
            process = true;
            Debug.Log(NowTurn +"ターン目 開始 / " + Weather +Demand + process);
        }
        
            
    }

    /*
    void PowerChange(){
        switch(Weather_int){
            case 1:
            CardEntity.instance.power = CardEntity.instance.power *3/2; break;
            case 2:
            break;
            case 3:
            CardEntity.instance.power = 0; break;
            case 4:
            CardEntity.instance.power = 0; break; 
        }

    }
    */

    void CreateCard(int cardID, Transform place){
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }

    /*void ShowTurn() // ターンを表示するメソッド
    {
        NowTurnTxt.text = NowTurn.ToString();
        MaxTurnTxt.text = MaxTurn.ToString();
        WeatherTxt.text = Weather;
        DemandTxt.text = Demand.ToString();
    }
    

    void ShowWeatherDemand() //天気、需要を表示するメソッド
    {
        WeatherTxt.text = Weather;
        DemandTxt.text = Demand.ToString();
    }

    void ShowCost() // コストを表示するメソッド
    {
        NowCost.text = NowCost.ToString();
        MaxCost.text = MaxCost.ToString();
    }*/

    void DrawCard(Transform hand){
        for (int i = 0; i < 2; i++){
            CreateCard(2, Hand);
            CreateCard(4, Hand);
        }
    }

 
    public void ChangeTurn(){

        this.End.SetActive (true);
        //子オブジェクトを一つずつ取得
        foreach (Transform child in Hand)
        {
            //削除する
            Destroy(child.gameObject);
        }

        foreach (Transform child in Ocean)
        {
            //削除する
            Destroy(child.gameObject);
        }

        foreach (Transform child in Land)
        {
            //削除する
            Destroy(child.gameObject);
        }

        /*計算
        void CalcSupply(){
            Supply = 0;
            for(int i = 0, i < len(カード数), i++)
            Supply += POWER;
        }
        */

        if(Demand>Supply){
            GameOver();
        }      


        if (NowTurn<MaxTurn){
            TurnEnd();

        }else{
            GameClear();
        }
    }

    void TurnEnd(){
        
        Debug.Log(NowTurn+"ターン目 終了");
        NowTurn++;
        process = false;
        TurnStart();
    } 

    public void GameOver(){
        this.Over.SetActive (true);
    }

    public void GameClear(){
        this.Clear.SetActive (true);
        
        Debug.Log(NowTurn+"ターン目 終了");
        Debug.Log("クリア");
    }

    public void GotoTitle(){
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    
}