using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;

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
