using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();
    public int x;
    public int deckSize = 40; // Set your deck size here

    void Start()
    {
        // Initialize the deck with random cards from CardDatabase
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, CardDatabase.cardList.Count); // Use Count to get the correct range
            deck.Add(CardDatabase.cardList[x]); // Use Add to populate the list
        }
    }

    public void Shuffle()
    {
        // Clear the container and then shuffle
        container.Clear();

        // Copy the deck into the container
        container.AddRange(deck);

        for (int i = 0; i < deck.Count; i++)
        {
            int randomIndex = Random.Range(0, container.Count);
            deck[i] = container[randomIndex];
            container.RemoveAt(randomIndex); // Remove to avoid duplicates
        }
    }
}
