using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;
    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;
    public Sprite spriteImage;
    public Image artImage;
    public bool cardBack;
    public static bool staticCardBack;

    void Start()
    {
        if (displayId < CardDatabase.cardList.Count)
        {
            // Add the card from the CardDatabase to the displayCard list
            Card cardToDisplay = CardDatabase.cardList[displayId];
            displayCard.Add(cardToDisplay); // Now displayCard[0] will be valid

            // Update the spriteImage variable after adding the card
            spriteImage = cardToDisplay.spriteImage;

            // Update the UI elements with the card information
            UpdateCardUI(cardToDisplay);
        }
        else
        {
            Debug.LogError("Invalid displayId");
        }
    }

    void Update()
    {
        staticCardBack = cardBack;
    }

    private void UpdateCardUI(Card card)
    {
        nameText.text = card.cardName;
        costText.text = card.cost.ToString();
        powerText.text = card.power.ToString();
        descriptionText.text = card.cardDescription;
        artImage.sprite = card.spriteImage;
        if (artImage.sprite == null)
        {
            Debug.LogError("Sprite is null for card: " + card.cardName);
        }
    }
}