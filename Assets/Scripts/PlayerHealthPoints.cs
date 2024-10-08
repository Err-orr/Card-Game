using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// This class manages the health points of the player in the game.
public class PlayerHealthPoints : MonoBehaviour
{
    // Static variables to hold the maximum health and a static health value.
    public static float maxHp; // The maximum health the player can have.
    public static float staticHp; // A static health value, can be modified as needed.
    // Current health of the player.
    public float hp; // The player's current health.
    // UI elements for displaying health as a visual bar and numeric text.
    public Image health; // Image component to visually represent health.
    public Text hpText; // Text component to display health points numerically.
    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        // Initialize maximum health and static health values.
        maxHp = 25000; // Set maximum health to 25,000.
        staticHp = 20000; // Set initial static health to 20,000.
    }
    // Update is called once per frame.
    void Update()
    {
        // Set current health to the static health value.
        hp = staticHp;
        // Update the fill amount of the health bar based on current health relative to max health.
        health.fillAmount = hp / maxHp;
        // Clamp the health value to not exceed max health.
        if (hp >= maxHp)
        {
            hp = maxHp; // Ensure health does not exceed the maximum.
        }
        // Update the health text display with the current health value.
        hpText.text = hp + "HP"; // Show current health in the UI.
    }
}