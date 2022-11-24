using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForeCast : MonoBehaviour
{
    public GameManager GM;
    [SerializeField] Text NowTurnTxt_1;
    [SerializeField] Text WeatherTxt_1;
    [SerializeField] Text DemandTxt_1;
    [SerializeField] Text SupplyTxt_1;

    // Start is called before the first frame update
    void Start()
    {
      /*  Debug.Log(NowTurnTxt_1);
        NowTurnTxt_1.text = GM.NowTurnTxt.text; 
        WeatherTxt_1.text = GM.WeatherTxt.text; 
        DemandTxt_1.text  = GM.DemandTxt.text;  
        SupplyTxt_1.text  = GM.SupplyTxt.text; */
    }

    void CallValue(){

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
