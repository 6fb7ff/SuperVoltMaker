using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardEntity", menuName = "Create CardEntity")]

public class CardEntity : ScriptableObject
{
    public static CardEntity instance;
    public int cardID;
    public new string name;
    public int cost;
    public int power;
    public Sprite icon;

}