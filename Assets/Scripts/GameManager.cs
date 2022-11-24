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
<<<<<<< HEAD
    [SerializeField] public Transform Hand, Ocean, Land;
    [SerializeField] public Text NowTurnTxt;
    [SerializeField] public Text NowTurnTxt_End;
    [SerializeField] public Text WeatherTxt;
    [SerializeField] public Text DemandTxt;
    [SerializeField] public Text DemandTxt_End;
    [SerializeField] public Text SupplyTxt;
    [SerializeField] Text CostPointTxt;
=======
    [SerializeField] Transform Hand, Ocean, Land;
    [SerializeField] Text NowTurnTxt;
    [SerializeField] Text MaxTurnTxt;
    [SerializeField] Text WeatherTxt;
    [SerializeField] Text DemandTxt;
    [SerializeField] Text SupplyTxt;
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
    [SerializeField] GameObject ForeCast;
    [SerializeField] GameObject End;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject Over;
<<<<<<< HEAD

    bool    process = false;
=======
    
    bool process    =false;
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
    int     NowTurn; // 現在ターン
    int     MaxTurn; // 最大ターン
    int     Weather_int;
    string  Weather;
    int     Demand;
<<<<<<< HEAD
    int     Supply = 5000;
    int     Point_Volt =0;
    public int CostPoint; // 使用したマナポイント

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
=======
    int     Supply = 200;
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7

    void Start(){
        StartGame();
    }
    

    void StartGame()
    { // 初期値の設定 
        NowTurn=1;
<<<<<<< HEAD
        MaxTurn=8;
        CostPoint = 0;
        ShowCostPoint();
        TurnStart();
    }

    void ShowCostPoint() // マナポイントを表示するメソッド
    {
    CostPointTxt.text = CostPoint.ToString();
    Debug.Log(CostPoint);
    }

    public void IncreaseCostPoint(int cost) // コストの分、マナポイントを減らす
    {
        CostPoint += cost;
        ShowCostPoint();
    }

    void TurnStart(){
        if(!process){
            DrawCard(Hand);
            Weather_int = Random.Range(1, 4);
            Demand_Random();
            switch( Weather_int )
            {
            case 1: Weather = "晴れ"; break;
            case 2: Weather = "曇り"; break;
            case 3: Weather = "雨"; break;
            case 4: Weather = "雷"; break;
            }

            if (NowTurn % 2 == 1){
                NowTurnTxt.text = (((NowTurn+1)/2).ToString() + "日目 午前"); 
            }else{
                NowTurnTxt.text = (((NowTurn+1)/2).ToString() + "日目 午後");
            }

            WeatherTxt.text = Weather;
            DemandTxt.text = Demand.ToString();  
            process = true;
            Debug.Log(NowTurn +"ターン目 開始");
        }          
    }
    
    void Demand_Random(){
        switch (NowTurn){
            case 1 : Demand = 2000 ;break;
            case 2 : Demand = 1500 ;break;
            case 3 : Demand = 3250 ;break;
            case 4 : Demand = 2750 ;break;
            case 5 : Demand = 2000 ;break;
            case 6 : Demand = 1500 ;break;
            case 7 : Demand = 5000 ;break;
            case 8 : Demand = 4500 ;break;
        }
        Demand += (Random.Range(1, 10))*50 -250;
=======
        MaxTurn=10;
        TurnStart();
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
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

<<<<<<< HEAD
/*
    void ShowForeCast(){
        this.ForeCast.SetActive (true);

    }*/
=======
            this.ForeCast.SetActive (true);
            NowTurnTxt.text = NowTurn.ToString();
            MaxTurnTxt.text = MaxTurn.ToString();
            WeatherTxt.text = Weather;
            DemandTxt.text = Demand.ToString();
            process = true;
            Debug.Log(NowTurn +"ターン目 開始 / " + Weather +Demand + process);
        }
        
            
    }
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7

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
        for (int i = 0; i < 1; i++){
            CreateCard(1, Hand);
            CreateCard(2, Hand);
            CreateCard(3, Hand);
            CreateCard(4, Hand);
            CreateCard(5, Hand);
        }
    }

 
    public void ChangeTurn(){

<<<<<<< HEAD
        //this.End.SetActive (true);
=======
        this.End.SetActive (true);
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
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

<<<<<<< HEAD


=======
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
        if(Demand>Supply){
            GameOver();
        }      


        if (NowTurn<MaxTurn){
<<<<<<< HEAD
            
            this.End.SetActive (true);
            if(End.activeSelf){
                Debug.Log("End is Active "+ Demand + "/ " + Supply);
                if (NowTurn % 2 == 1){
                    NowTurnTxt_End.text = (((NowTurn+1)/2).ToString() + "日目 午前"); 
                }else{
                    NowTurnTxt_End.text = (((NowTurn+1)/2).ToString() + "日目 午後");
                }
                DemandTxt_End.text = Demand.ToString();
            }
=======
            TurnEnd();
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7

        }else{
            GameClear();
        }
    }

<<<<<<< HEAD
    public void TurnEnd(){
        
        //Debug.Log(NowTurn+"ターン目 終了");
=======
    void TurnEnd(){
        
        Debug.Log(NowTurn+"ターン目 終了");
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
        NowTurn++;
        process = false;
        TurnStart();
    } 

<<<<<<< HEAD

=======
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
    public void GameOver(){
        this.Over.SetActive (true);
    }

    public void GameClear(){
        this.Clear.SetActive (true);
        
<<<<<<< HEAD
        //Debug.Log(NowTurn+"ターン目 終了");
        //Debug.Log("クリア");
=======
        Debug.Log(NowTurn+"ターン目 終了");
        Debug.Log("クリア");
>>>>>>> 009b0b981b9fcf6015cd9af8f9de62232990e0c7
    }

    public void GotoTitle(){
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    
}