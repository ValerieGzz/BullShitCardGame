
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DisplayCard : MonoBehaviour
{
    public int displayValue; // The index of the card in CardDataBase.cardList
    public Image artImage;   // The UI Image component on your card object

    public bool cardBack;
    public static bool staticCardBack; 


    void Start()
    {
        Debug.Log(CardDataBase.cardList.Count); 

        // 1. Check if the database list is initialized and valid
        if (CardDataBase.cardList == null || CardDataBase.cardList.Count == 0)
        {
            Debug.LogError("CardDataBase.cardList is empty or hasn't initialized yet!");
            return;
        }

        // 2. Validate the displayValue index
        if (displayValue >= 0 && displayValue < CardDataBase.cardList.Count)
        {
            Card cardData = CardDataBase.cardList[displayValue];

            // 3. Assign the sprite directly to the UI Image component
            if (artImage != null && cardData.spriteImage != null)
            {
                artImage.sprite = cardData.spriteImage; 

            }
            else
            {
                Debug.LogError("Art Image component or card sprite image is missing!");
            }
        }
        else
        {
            Debug.LogError($"Display Value ({displayValue}) is out of range!");
        }
    }

    void Update()
    {
        staticCardBack = cardBack; 

    }
}
