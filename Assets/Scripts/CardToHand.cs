using UnityEngine;
// Class responsible for moving a card to the player's hand in the UI
public class CardToHand : MonoBehaviour
{
    // Reference to the GameObject representing the hand
    public GameObject Hand;
    // Reference to the card GameObject that will be added to the hand
    public GameObject HandCard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the Hand GameObject in the scene
        Hand = GameObject.Find("Hand");
    }

    // Update is called once per frame
    void Update()
    {
        // Set the HandCard's parent to the Hand GameObject
        HandCard.transform.SetParent(Hand.transform);
        // Reset the scale of the HandCard to ensure it appears correctly in the hand
        HandCard.transform.localScale = Vector3.one;
        // Position the HandCard above the current object's position with a fixed z-axis value
        HandCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        // Set the rotation of the HandCard for visual presentation
        HandCard.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}