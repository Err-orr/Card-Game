using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
    void Awake()
    {
        Sprite fireballSprite = Resources.Load<Sprite>("FireballV2");
        Sprite poisonSprite = Resources.Load<Sprite>("Poison");
        Sprite healSprite = Resources.Load<Sprite>("Healing");
        Sprite hailSprite = Resources.Load<Sprite>("Hail");
        Sprite lightningSprite = Resources.Load<Sprite>("Lightning");
        Sprite cupcakeSprite = Resources.Load<Sprite>("Cupcake");
        // Example for one card
        if (fireballSprite == null)
        {
            Debug.LogError("Failed to load fireball sprite. Check the file path and name.");
        }
        if (poisonSprite == null)
        {
            Debug.LogError("Failed to load poison sprite. Check the file path and name.");
        }
        if (healSprite == null)
        {
            Debug.LogError("Failed to load heal sprite. Check the file path and name.");
        }
        if (hailSprite == null)
        {
            Debug.LogError("Failed to load hail sprite. Check the file path and name.");
        }
        if (lightningSprite == null)
        {
            Debug.LogError("Failed to load lightning sprite. Check the file path and name.");
        }
        if (cupcakeSprite == null)
        {
            Debug.LogError("Failed to load cupcake sprite. Check the file path and name.");
        }
        cardList.Add(new Card(0, "Fireball", 1, 3, "A deadly ball of fire.", fireballSprite));
        cardList.Add(new Card(1, "Uncommon Fireball", 1, 5, "A deadly ball of fire. Hits stronger.", fireballSprite));
        cardList.Add(new Card(2, "Rare Fireball", 1, 6, "A deadly ball of fire. Hits massively stronger.", fireballSprite));
        cardList.Add(new Card(3, "Epic Fireball", 1, 8, "A deadly ball of fire. Hits insanely stronger.", fireballSprite));
        cardList.Add(new Card(4, "Legendary Fireball", 1, 9, "A deadly ball of fire. Hits outrageously stronger.", fireballSprite));
        cardList.Add(new Card(5, "Poison", 1, 2, "A bottle of poison.", poisonSprite));
        cardList.Add(new Card(6, "Uncommon Poison", 1, 3, "A bottle of poison. Hits stronger.", poisonSprite));
        cardList.Add(new Card(7, "Rare Poison", 1, 4, "A bottle of poison. Hits massively stronger.", poisonSprite));
        cardList.Add(new Card(8, "Epic Poison", 1, 5, "A bottle of poison. Hits insanely stronger.", poisonSprite));
        cardList.Add(new Card(9, "Legendary Poison", 1, 6, "A bottle of. Hits outrageously stronger.", poisonSprite));
        cardList.Add(new Card(10, "Heal", 1, 1, "A surge of healing.", healSprite));
        cardList.Add(new Card(11, "Uncommon Heal", 1, 2, "A strong surge of healing.", healSprite));
        cardList.Add(new Card(12, "Rare Heal", 1, 3, "A massive surge of healing.", healSprite));
        cardList.Add(new Card(13, "Epic Heal", 1, 4, "An insane surge of healing.", healSprite));
        cardList.Add(new Card(14, "Legendary Heal", 1, 5, "An outrageous surge of healing.", healSprite));
        cardList.Add(new Card(15, "Hail", 2, 4, "A cloud of hail.", hailSprite));
        cardList.Add(new Card(16, "Uncommon Hail", 2, 6, "A cloud of hail. Hits stronger.", hailSprite));
        cardList.Add(new Card(17, "Rare Hail", 2, 8, "A cloud of hail. Hits massively stronger.", hailSprite));
        cardList.Add(new Card(18, "Epic Heal", 2, 10, "A cloud of hail. Hits insanely stronger.", hailSprite));
        cardList.Add(new Card(19, "Lightning", 3, 6, "A hard-hitting bolt of electricity strikes upon foes.", lightningSprite));
        cardList.Add(new Card(20, "Uncommon Lightining", 3, 9, "A hard-hitting bolt of electricity strikes upon foes. Hits stronger.", lightningSprite));
        cardList.Add(new Card(21, "Rare Lightning", 3, 12, "A hard-hitting bolt of electricity strikes upon foes. Hits massively stronger.", lightningSprite));
        cardList.Add(new Card(22, "Epic Lightning", 3, 15, "A hard-hitting bolt of electricity strikes upon foes. Hits insanely stronger.", lightningSprite));
        cardList.Add(new Card(23, "Legendary Lightning", 3, 18, "A hard-hitting bolt of electricity strikes upon foes. Hits outrageously stronger.", lightningSprite));
        cardList.Add(new Card(24, "Cupcake", 1, 2, "What a nice tasty cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(25, "Uncommon Cupcake", 1, 4, "What a nice, strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(26, "Rare Cupcake", 1, 6, "What a nice, massively strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(27, "Epic Cupcake", 1, 8, "What a nice, insanely strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(28, "Legendary Cupcake", 1, 10, "What a nice, outrageously strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
    }
}