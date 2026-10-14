using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayValue;

    public int value;
    public string rank;
    public string suit;
    public Sprite spriteImage; 

    public Text rankText;
    public Text suitText;
    public Text valueText;
    public Image artImage; 

    private void Start()
    {
        displayCard[0] = CardDataBase.cardList[displayValue];
        value = displayCard[0].value;
        rank = displayCard[0].rank;
        suit = displayCard[0].suit;
        spriteImage = displayCard[0].spriteImage;

        rankText.text = " " + rank;
        suitText.text = " " + suit;
        valueText.text = " " + value;
        artImage.sprite = spriteImage; 

    }

    void Update()
    {

    }

}
/*
public class DisplayCard : MonoBehaviour 
{
    public Card CardDataBase; 
    public Image cardImageUI; 
    public void SetupCard(Card card)
    {
        CardDataBase = card;
        UpdateCardSprite(); 
    }

    public void UpdateCardSprite()
    {
        if (CardDataBase != null) return;
        string spritePath = "Cards/" + CardDataBase.rank + "_of_" + CardDataBase.suit;
        Sprite cardSprite = Resources.Load<Sprite>(spritePath); 

        if (cardSprite != null )
        {
            cardImageUI.sprite = cardSprite;
        }

    }
}
*/