using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 


public class CardDisplay : MonoBehaviour
{
    public List<Card> cardDisplay = new List<Card>();
    public int displayValue;

    public int value; 
    public string rank;
    public string suit;

    public Text rankText; 
    public Text suitText;
    public Text valueText; 

    private void Start()
    {
        cardDisplay[0] = CardDataBase.cardList[displayValue];
        value = cardDisplay[0].value;
        rank = cardDisplay[0].rank;  
        suit = cardDisplay[0].suit;

        rankText.text = " " + rank; 
        suitText.text = " " + suit;
        valueText.text = " " + value;

    }

    void Update()
    {

    }

}
