using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI; 


public class CardDisplay : MonoBehaviour
{
    public int displayValue; 
    public Text nameText;
    public Text rankText;
    public Text suitText;
    public Text valueText;

    void Start()
    {
        // Check if database list is valid and index is in range
        if (CardDataBase.cardList != null && displayValue >= 0 && displayValue < CardDataBase.cardList.Count)
        {
            // Assuming your CardDataBase uses Card2 type or can be converted
            var card = CardDataBase.cardList[displayValue];

            if (rankText != null) rankText.text = card.rank;
            if (suitText != null) suitText.text = card.suit;
            if (valueText != null) valueText.text = card.value.ToString();
        }
        else
        {
            Debug.LogError("Display value is out of range or CardDataBase is empty!");
        }
    }

}
