using UnityEngine;
// Class that manages the display of a card in the deck panel
public class DeckPanelCard : MonoBehaviour
{
    // Reference to the GameObject representing the card back
    public GameObject cardBack;
    // Update is called once per frame
    void Update()
    {
        // Continuously set the card back to active (visible) each frame
        cardBack.SetActive(true);
    }
}