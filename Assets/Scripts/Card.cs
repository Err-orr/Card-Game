using UnityEngine;
// Serializable class representing a card
[System.Serializable]
public class Card
{
    // Unique identifier for the card
    public int id;
    // Name of the card
    public string cardName;
    // Cost to play the card
    public int cost;
    // Power of the card, used for combat or effects
    public int power;
    // Description of the card's abilities or lore
    public string cardDescription;
    // Image representing the card (typically a visual asset)
    public Sprite spriteImage;
    // Default constructor for the Card class
    public Card()
    {
        // Initialize card fields with default values
        id = 0;
        cardName = "";
        cost = 0;
        power = 0;
        cardDescription = "";
    }
    // Parameterized constructor for the Card class
    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, Sprite SpriteImage)
    {
        // Assign values to the card fields from the parameters
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
        spriteImage = SpriteImage;
    }
}