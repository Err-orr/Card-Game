using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// This class manages the health points of an opponent in the game.
public class OpponentHealthPoints : MonoBehaviour
{
    // Static variables to hold the maximum health and a static health value.
    public static float maxHp;
    public static float staticHp;
    // Current health of the opponent.
    public float hp;
    // UI elements for displaying health as a visual bar and numeric text.
    public Image health;
    public Text hpText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        // Initialize maximum health and static health values.
        maxHp = 25000;
        staticHp = 5000;
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
            hp = maxHp;
        }
        // Update the health text display with the current health value.
        hpText.text = hp + "HP";
    }
}