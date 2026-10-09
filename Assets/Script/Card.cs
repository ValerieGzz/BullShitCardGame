using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]

// public enum Suit { Hearts, Dimonds, Clubs, Spades }
// public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
public class Card : MonoBehaviour
{
    public string rank;
    public string suit;
    public int value; 

    public Card()
    {

    }

    public Card(string Rank, string Suit, int Value )
    {
        rank = Rank; 
        suit = Suit;
        value = Value;  
    }

    // public Suit suit; 
    // public Rank rank;
    // public Sprite cardSprite; 

    // public Card(Suit s, Rank r, Sprite sprite)
  // {
       //  suit = s;
       //  rank = r; 
       //  cardSprite = sprite;
    // }
}
