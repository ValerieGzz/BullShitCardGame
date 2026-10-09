using System.Collections.Generic; 
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> centralPile = new List<Card>();
    public Rank currentRequiredRank;

    private void Start()
    {
        StartNewTurnSquences(); 
    }

    void StartNewTurnSquences()
    {
        // Set the rank expected for this turn 
        currentRequiredRank = Rank.Two; 
    }

    // call when player submitts a card to the pile 
    public void PlayCards(List<Card> submittedCards, Rank claimedRank, bool isHandActuallyTellingTheTruth)
    {
        // Add cards face down in the pile 
        centralPile.AddRange(submittedCards);
        // next players turn and allow the player to call BS 
    }

    // call wbe another player calles BS 
    public void CallBullshit(int challengerIndex, int cardProviderIndex, List<Card> cardsJustPlayed, Rank claimedRank)
    {
        bool wasActuallyTrue = true;

        foreach (var card in cardsJustPlayed)
        {
            if (card.rank != claimedRank)
            {
                wasActuallyTrue = false;
                break;
            }
        }

        if (wasActuallyTrue)
        {
            // player is wrong and has to pick up pile 
            GivePileToPlayer(challengerIndex);
        }
        else
        {
            // player was right give the cards to to opposite player 
            GivePileToPlayer(cardProviderIndex); 
        }

        centralPile.Clear(); 
    } 

    private void GivePileToPlayer(int playerIndex)
    {
        // transfer center cards to one of the players hands 
    }
    
}
