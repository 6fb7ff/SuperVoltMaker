using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform Hand, Ocean, Land;

    int turncount;
    //int demand,supply;

    void Start(){
        StartGame();
    }

    void StartGame(){ // 初期値の設定 {
        // ターンの決定
        turncount = 0;
        DrawCard(Hand);        
    }

    void CreateCard(int cardID, Transform place){
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }


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

        turncount++;

        Debug.Log(turncount);

        /*ゲームオーバー判定
        if(demand>supply){
            GameOver()
        }      
        */

        if (turncount<10){
            PlayerTurn();
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