using UnityEngine;
// Class responsible for managing the visibility of the card back
public class CardBack : MonoBehaviour
{
    // Reference to the GameObject representing the card back
    public GameObject cardBack;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialization logic can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Check the static variable from the DisplayCard class to determine card back visibility
        if (DisplayCard.staticCardBack)
        {
            // Activate the card back GameObject if staticCardBack is true
            cardBack.SetActive(true);
        } else
        {
            // Deactivate the card back GameObject if staticCardBack is false
            cardBack.SetActive(false);
        }
    }
}