using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour 
{
    public List<Card> centralPile = new List<Card>();
    public void DroppingCardsInDropZone(List<Card> submittedCards, Rank claimedRank)
    {
        // Safety check: Make sure cards were actually passed in
        if (submittedCards != null && submittedCards.Count > 0)
        {
            // Add the new cards into the central game pile
            centralPile.AddRange(submittedCards); 
        }
    }

}
