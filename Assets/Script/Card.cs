using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public enum Suit { Hearts, Dimonds, Clubs, Spades }
public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }


[System.Serializable]
public class Card 
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
}
