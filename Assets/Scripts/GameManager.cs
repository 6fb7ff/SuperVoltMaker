using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Card_01; //火力
    [SerializeField] GameObject Card_02; //太陽光
    [SerializeField] Transform Hand, Ocean, Land; //手札


    void Start()
    {
        for (int i = 0; i < 2; i++) 
        {
            Instantiate(Card_01, Hand);
            Instantiate(Card_02, Hand);
        }

    }
}