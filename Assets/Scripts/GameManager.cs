using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform Hand, Ocean, Land;
    [SerializeField] Text NowTurnTxt;
    [SerializeField] Text MaxTurnTxt;

    public int NowTurn; // 現在ターン
    public int MaxTurn; // 最大ターン

    //int demand,supply;

    void Start(){
        StartGame();
    }

    void StartGame(){ // 初期値の設定 {
        // ターンの決定
        NowTurn=1;
        MaxTurn=10;
        ShowTurn();
        DrawCard(Hand);        
    }



    void CreateCard(int cardID, Transform place){
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }

    void ShowTurn() // ターンを表示するメソッド
    {
        NowTurnTxt.text = NowTurn.ToString();
        MaxTurnTxt.text = MaxTurn.ToString();
    }

    /*void ShowCost() // コストを表示するメソッド
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

        Debug.Log(NowTurn);

        /*ゲームオーバー判定
        if(demand>supply){
            GameOver()
        }      
        */

        if (NowTurn<MaxTurn){
            PlayerTurn();
            NowTurn++;
            ShowTurn();
        }else{
            GameEnd();
        }
    }
 
    void PlayerTurn(){
        Debug.Log("Playerのターン");
        DrawCard(Hand);
    }

    void GameEnd(){
        //クリア処理
    }
}