using UnityEngine;

[System.Serializable]
public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public Sprite spriteImage;

    public Card()
    {
        id = 0;
        cardName = "";
        cost = 0;
        power = 0;
        cardDescription = "";
    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, Sprite SpriteImage)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
        spriteImage = SpriteImage;
    }
}