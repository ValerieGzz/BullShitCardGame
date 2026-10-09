using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class Deck : MonoBehaviour 
{
    public List<Card> deck = new List<Card>();
    public int x;

    private void Start()
    {
        x = 0;

        for (int i = 0; i < 52; i++)
        {
            x = Random.Range(1, 26);
            deck[i] = CardDataBase.cardList[x];

        }
    }

    private void Update()
    {
        
    }
}
