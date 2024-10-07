using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Class that manages the player's deck of cards
public class PlayerDeck : MonoBehaviour
{
    // List to hold the player's deck of cards
    public List<Card> deck = new List<Card>();
    // Static list to share the deck with other components
    public static List<Card> staticDeck = new List<Card>();
    // Container used for shuffling the deck
    public List<Card> container = new List<Card>();
    // Variable for managing card count (not currently used)
    public int x;
    // Static variable to define the size of the deck
    public static int deckSize = 40; // Set your deck size here
    // GameObjects representing cards in the deck for UI purposes
    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    // Array to hold clones of card GameObjects
    public GameObject[] Clones;
    // Reference to the Hand GameObject where cards will be played
    public GameObject Hand;
    // Prefab for the card to be instantiated into the hand
    public GameObject CardToHand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize the deck with random cards from CardDatabase
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, CardDatabase.cardList.Count); // Randomly select an index for the card
            deck.Add(CardDatabase.cardList[x]); // Add the selected card to the deck
        }
        StartCoroutine(StartGame()); // Start the game by drawing initial cards
    }
    // Update is called once per frame
    void Update()
    {
        // Update the staticDeck to reflect the current deck
        staticDeck = deck;
        // Manage visibility of card indicators based on remaining deck size
        if (deckSize < 30)
        {
            cardInDeck1.SetActive(false); // Hide indicator if deck size is below 30
        }
        if (deckSize < 20)
        {
            cardInDeck2.SetActive(false); // Hide indicator if deck size is below 20
        }
        if (deckSize < 10)
        {
            cardInDeck3.SetActive(false); // Hide indicator if deck size is below 10
        }
        if (deckSize < 5)
        {
            cardInDeck4.SetActive(false); // Hide indicator if deck size is below 5
        }
        // Check if it's the start of a new turn to draw a card
        if (TurnSystem.startTurn)
        {
            StartCoroutine(Draw(1)); // Draw one card when the turn starts
            TurnSystem.startTurn = false; // Reset the start turn flag
        }
    }
    // Coroutine to start the game by instantiating initial cards
    IEnumerator StartGame()
        {
            for (int i = 0; i <= 3; i++)
            {
                yield return new WaitForSeconds(1); // Wait for 1 second before drawing each card
            Instantiate(CardToHand, transform.position, transform.rotation); // Instantiate a card in the hand
        }
        }
    // Method to shuffle the deck of cards
    public void Shuffle()
    {
        // Clear the container before shuffling
        container.Clear();

        // Copy the current deck into the container
        container.AddRange(deck);
        // Shuffle the cards in the deck
        for (int i = 0; i < deck.Count; i++)
        {
            int randomIndex = Random.Range(0, container.Count); // Select a random index
            deck[i] = container[randomIndex]; // Assign the randomly selected card to the deck
            container.RemoveAt(randomIndex); // Remove the card to avoid duplicates
        }
    }
    // Coroutine to draw a specified number of cards
    IEnumerator Draw(int x)
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(1); // Wait before drawing each card
            Instantiate(CardToHand, transform.position, transform.rotation); // Instantiate a card in the hand
        }
    }

}