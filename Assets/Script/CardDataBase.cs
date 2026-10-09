using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card(Suit.Hearts,Rank.Three,Resources.Load <Sprite> ("card_back"))); 
    }

}