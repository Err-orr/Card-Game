using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
// Class responsible for displaying card information in the UI
public class DisplayCard : MonoBehaviour
{
    // List to hold cards that are currently displayed
    public List<Card> displayCard = new List<Card>();
    // ID of the card to display
    public int displayId;
    // UI Text elements to show card information
    public Text nameText;          // Text field for the card's name
    public Text costText;          // Text field for the card's cost
    public Text powerText;         // Text field for the card's power
    public Text descriptionText;   // Text field for the card's description
    // Sprite for the card image
    public Sprite spriteImage;
    // UI Image to display the card's art
    public Image artImage;
    // Boolean to indicate if the card is a back card
    public bool cardBack;
    // Static boolean to track card back state across instances
    public static bool staticCardBack;
    // Reference to the Hand GameObject in the scene
    public GameObject Hand;
    // Number of cards currently in the player's deck
    public int numberOfCardsInDeck;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the number of cards in the deck from the PlayerDeck
        numberOfCardsInDeck = PlayerDeck.deckSize;
    }
    // Update is called once per frame
    void Update()
    {
        // Check if the displayId is valid
        if (displayId < CardDatabase.cardList.Count)
        {
            // Retrieve the card from the CardDatabase based on displayId
            Card cardToDisplay = CardDatabase.cardList[displayId];
            displayCard.Add(cardToDisplay); // Add the card to the displayCard list

            // Update the spriteImage variable with the card's image
            spriteImage = cardToDisplay.spriteImage;

            // Update the UI elements with the card's information
            UpdateCardUI(cardToDisplay);
        }
        else
        {
            // Log an error if the displayId is invalid
            Debug.LogError("Invalid displayId");
        }
        // Find the Hand GameObject in the scene
        Hand = GameObject.Find("Hand");
        // Check if the current object's parent is the same as Hand's parent
        if (this.transform.parent == Hand.transform.parent)
        {
            cardBack = false; // Set cardBack to false if it is part of the hand
        }
        // Update the staticCardBack status
        staticCardBack = cardBack;
        // If the object is tagged as "Clone"
        if (this.tag == "Clone")
        {
            // Update the displayCard list with the last card in the player's static deck
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1; // Decrease the number of cards in the deck
            PlayerDeck.deckSize -= 1; // Update the deck size
            cardBack = false; // Reset cardBack state
            this.tag = "Untagged"; // Remove the "Clone" tag
        }
    }
    // Method to update the UI elements with the selected card's information
    private void UpdateCardUI(Card card)
    {
        // Set UI text fields with card information
        nameText.text = card.cardName;                      // Set card name
        costText.text = card.cost.ToString();               // Set card cost
        powerText.text = card.power.ToString();             // Set card power
        descriptionText.text = card.cardDescription;        // Set card description
        artImage.sprite = card.spriteImage;                 // Set card art image
        // Check if the sprite is null and log an error if it is
        if (artImage.sprite == null)
        {
            Debug.LogError("Sprite is null for card: " + card.cardName);
        }
    }
}