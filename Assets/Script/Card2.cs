using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card2 : ScriptableObject
{
    public string rank; 
    public string suit;
    public int value; 

    public void Print()
    {
       
    }
}
