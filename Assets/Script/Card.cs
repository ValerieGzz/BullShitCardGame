using NUnit.Framework;
using UnityEngine;

public enum Suit { Hearts, Dimonds, Clubs, Spades }
public enum Rank { Two = 2,  Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
public class Card : MonoBehaviour
{
    public Suit suit; 
    public Rank rank;
    public Sprite cardSprite; 

    public Card(Suit s, Rank r, Sprite sprite)
    {
        suit = s;
        rank = r; 
        cardSprite = sprite;
    }
}
