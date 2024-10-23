using UnityEngine;
using UnityEngine.UI;
// Class that manages the turn-based system for players and opponents
public class TurnSystem : MonoBehaviour
{
    // Boolean indicating if it is the player's turn
    public bool isYourTurn;
    // Counter for the player's turns
    public int yourTurn;
    // Counter for the opponent's turns
    public int isOpponentTurn;
    // Text UI element to display the current turn
    public Text turnText;
    // Maximum amount of mana available to the player
    public int maxMana;
    // Current amount of mana available to the player
    public int currentMana;
    // Text UI element to display the current mana status
    public Text manaText;
    // Static boolean to indicate if a turn has started
    public static bool startTurn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize turn and mana variables
        isYourTurn = true;          // Set player's turn to true
        yourTurn = 1;               // Initialize player's turn count
        isOpponentTurn = 0;         // Initialize opponent's turn count
        maxMana = 1;                // Set initial maximum mana
        currentMana = 1;            // Set current mana to match maximum
        startTurn = false;          // Reset turn start status
    }

    // Update is called once per frame
    void Update()
    {
        // Update the turn text based on whose turn it is.
        if (isYourTurn)
        {
            turnText.text = "Your Turn"; // Display your turn
        } else
        {
            turnText.text = "Opponent's Turn"; // Display the opponent's turn
        }
        // Update the cost/mana text to show what current and maximum cost/mana is.
        manaText.text = currentMana + "/" + maxMana;
    }
    // Here's the method to end the player's turn
    public void EndYourTurn()
    {
        isYourTurn = false;            // This is false so the player doesn't go.
        isOpponentTurn += 1;           // Increments how many times the opponent went.
    }
    // Here's the method to end the opponent's turn and prepare for the player's next turn
    public void EndOpponentTurn()
    {
        isYourTurn = true;             // Set player's turn to true so they can play next turn.
        yourTurn += 1;                 // Increments how many times the player went.
        maxMana += 1;                  // Increase the max mana/cost by 1.
        currentMana = maxMana;         // Reset current mana to maximum for the player's next turn.
        startTurn = true;              // Indicates that a new turn has begun.
    }
}