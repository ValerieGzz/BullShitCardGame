using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

    public static List<Card> cardList = new List<Card>();

     void Awake()
    {
        // public Card(string Rank, string Suit, int Value ) this is the correct format 

        cardList.Add(new Card("Ace", "Clubs", 1, Resources.Load<Sprite>("ace_of_clubs"));
        cardList.Add(new Card("Ace", "Dimonds", 1, Resources.Load<Sprite>("ace_of_dimonds"));
        cardList.Add(new Card("Ace", "Hearts", 1, Resources.Load<Sprite>("ace_of_hearts"));
        cardList.Add(new Card("Ace", "Spades", 1, Resources.Load<Sprite>("ace_of_spades"));

        cardList.Add(new Card("Two", "Clubs", 2, Resources.Load<Sprite>("2_of_clubs"));
        cardList.Add(new Card("Two", "Dimonds", 2, Resources.Load<Sprite>("2_of_dimonds"));
        cardList.Add(new Card("Two", "Hearts", 2, Resources.Load<Sprite>("2_of_hearts"));
        cardList.Add(new Card("Two", "Spades", 2, Resources.Load<Sprite>("2_of_spades"));

        cardList.Add(new Card("Three", "Clubs", 3, Resources.Load<Sprite>("3_of_clubs"));
        cardList.Add(new Card("Three", "Dimonds", 3, Resources.Load<Sprite>("3_of_dimonds"));
        cardList.Add(new Card("Three", "Hearts", 3, Resources.Load<Sprite>("3_of_hearts"));
        cardList.Add(new Card("Three", "Spades", 3, Resources.Load<Sprite>("3_of_spades"));

        cardList.Add(new Card("Four", "Clubs", 4, Resources.Load<Sprite>("4_of_clubs"));
        cardList.Add(new Card("Four", "Dimonds", 4, Resources.Load<Sprite>("4_of_dimonds"));
        cardList.Add(new Card("Four", "Hearts", 4, Resources.Load<Sprite>("4_of_hearts"));
        cardList.Add(new Card("Four", "Spades", 4, Resources.Load<Sprite>("4_of_spades"));

        cardList.Add(new Card("Five", "Clubs", 5, Resources.Load<Sprite>("5_of_clubs"));
        cardList.Add(new Card("Five", "Dimonds", 5, Resources.Load<Sprite>("5_of_dimonds"));
        cardList.Add(new Card("Five", "Hearts", 5, Resources.Load<Sprite>("5_of_hearts"));
        cardList.Add(new Card("Five", "Spades", 5, Resources.Load<Sprite>("5_of_spades"));

        cardList.Add(new Card("Six", "Clubs", 6, Resources.Load<Sprite>("6_of_clubs"));
        cardList.Add(new Card("Six", "Dimonds", 6, Resources.Load<Sprite>("6_of_dimonds"));
        cardList.Add(new Card("Six", "Hearts", 6, Resources.Load<Sprite>("6_of_hearts"));
        cardList.Add(new Card("Six", "Spades", 6, Resources.Load<Sprite>("6_of_spades"));

        cardList.Add(new Card("Seven", "Clubs", 7, Resources.Load<Sprite>("7_of_clubs"));
        cardList.Add(new Card("Seven", "Dimonds", 7, Resources.Load<Sprite>("7_of_dimonds"));
        cardList.Add(new Card("Seven", "Hearts", 7, Resources.Load<Sprite>("7_of_hearts"));
        cardList.Add(new Card("Seven", "Spades", 7, Resources.Load<Sprite>("7_of_spades"));

        cardList.Add(new Card("Eight", "Clubs", 8, Resources.Load<Sprite>("8_of_clubs"));
        cardList.Add(new Card("Eight", "Dimonds", 8, Resources.Load<Sprite>("8_of_dimonds"));
        cardList.Add(new Card("Eight", "Hearts", 8, Resources.Load<Sprite>("8_of_hearts"));
        cardList.Add(new Card("Eight", "Spades", 8, Resources.Load<Sprite>("8_of_spades"));

        cardList.Add(new Card("Nine", "Clubs", 9, Resources.Load<Sprite>("9_of_clubs"));
        cardList.Add(new Card("Nine", "Dimonds", 9, Resources.Load<Sprite>("9_of_dimonds"));
        cardList.Add(new Card("Nine", "Hearts", 9, Resources.Load<Sprite>("9_of_hearts"));
        cardList.Add(new Card("Nine", "Spades", 9, Resources.Load<Sprite>("9_of_spades"));

        cardList.Add(new Card("Ten", "Clubs", 10, Resources.Load<Sprite>("10_of_clubs"));
        cardList.Add(new Card("Ten", "Dimonds", 10, Resources.Load<Sprite>("10_of_dimonds"));
        cardList.Add(new Card("Ten", "Hearts", 10, Resources.Load<Sprite>("10_of_hearts"));
        cardList.Add(new Card("Ten", "Spades", 10, Resources.Load<Sprite>("10_of_spades"));
        
        cardList.Add(new Card("Jack" ,"Clubs", 11, Resources.Load<Sprite>("jack_of_clubs")));
        cardList.Add(new Card("Jack", "Dimonds", 11, Resources.Load<Sprite>("jack_of_dimonds")));
        cardList.Add(new Card("Jack", "Hearts" , 11, Resources.Load<Sprite>("jack_of_hearts")));
        cardList.Add(new Card("Jack", "Spades", 11, Resources.Load<Sprite>("jack_of_spades")));

        cardList.Add(new Card("Queen", "Clubs", 12, Resources.Load<Sprite>("queen_of_clubs")));
        cardList.Add(new Card("Queen", "Dimonds", 12, Resources.Load<Sprite>("queen_of_dimonds")));
        cardList.Add(new Card("Queen", "Hearts", 12, Resources.Load<Sprite>("queen_of_hearts")));
        cardList.Add(new Card("Queen", "Spades", 12, Resources.Load<Sprite>("queen_of_spades")));

        cardList.Add(new Card("King", "Clubs", 13, Resources.Load<Sprite>("king_of_clubs")));
        cardList.Add(new Card("King", "Dimonds", 13, Resources.Load<Sprite>("king_of_dimonds")));
        cardList.Add(new Card("King", "Hearts", 13, Resources.Load<Sprite>("king_of_hearts")));
        cardList.Add(new Card("King", "Spades", 13, Resources.Load<Sprite>("king_of_spades")));

        // this is the wrong format 
        // cardList.Add(new Card(Suit.Clubs, Rank.Ace, Resources.Load<Sprite>("ace_of_clubs")));
        // cardList.Add(new Card(Suit.Dimonds, Rank.Ace, Resources.Load<Sprite>("ace_of_dimonds")));
        // cardList.Add(new Card(Suit.Hearts, Rank.Ace, Resources.Load<Sprite>("ace_of_hearts")));
        // cardList.Add(new Card(Suit.Spades, Rank.Ace, Resources.Load<Sprite>("ace_of_spades")));

    }

}