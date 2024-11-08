using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
// Class responsible for managing the card database
public class CardDatabase : MonoBehaviour
{
    // Static list to hold all the cards in the game
    public static List<Card> cardList = new List<Card>();
    // Awake is called when the script instance is being loaded
    void Awake()
    {
        // Load sprites for different cards from the Resources folder
        Sprite fireballSprite = Resources.Load<Sprite>("CardArt/Fireball");
        Sprite poisonSprite = Resources.Load<Sprite>("CardArt/Poison");
        Sprite healSprite = Resources.Load<Sprite>("CardArt/Healing");
        Sprite lightningSprite = Resources.Load<Sprite>("CardArt/Lightning");
        Sprite cupcakeSprite = Resources.Load<Sprite>("CardArt/Cupcake");
        Sprite diamondSwordSprite1 = Resources.Load<Sprite>("CardArt/DiamondTintedSword");
        Sprite dodgeBallSprite = Resources.Load<Sprite>("CardArt/Ball");
        Sprite pizzaSprite = Resources.Load<Sprite>("CardArt/Pizza");
        Sprite sunflowerSprite = Resources.Load<Sprite>("CardArt/Sunflower");
        Sprite electricTreeSprite = Resources.Load<Sprite>("CardArt/ElectricTree");
        Sprite explosionSprite = Resources.Load<Sprite>("CardArt/Explosion");
        Sprite spearSprite = Resources.Load<Sprite>("CardArt/Spear");
        Sprite fistSprite = Resources.Load<Sprite>("CardArt/Fist");
        Sprite electricitySprite = Resources.Load<Sprite>("CardArt/Electricity");
        Sprite dualWieldSprite = Resources.Load<Sprite>("CardArt/DualWieldSwords");
        Sprite freezeSprite = Resources.Load<Sprite>("CardArt/FreezeSpell");
        Sprite gargantuaSprite = Resources.Load<Sprite>("CardArt/Gargantua");
        Sprite tentaclesSprite = Resources.Load<Sprite>("CardArt/Tentacles");
        Sprite sonicFlashSprite = Resources.Load<Sprite>("CardArt/SonicFlash");
        Sprite mysterySprite = Resources.Load<Sprite>("CardArt/MysteryCard");
        Sprite spiderWebSprite = Resources.Load<Sprite>("CardArt/SpiderWeb");
        Sprite supernovaSprite = Resources.Load<Sprite>("CardArt/SuperNova");
        Sprite jellybeanSprite = Resources.Load<Sprite>("CardArt/Jellybean");
        Sprite potatoSprite = Resources.Load<Sprite>("CardArt/PotatoOfDeath");
        Sprite skullSprite = Resources.Load<Sprite>("CardArt/Skull");
        Sprite shieldSprite = Resources.Load<Sprite>("CardArt/Shield");
        Sprite wofSprite = Resources.Load<Sprite>("CardArt/WallOfFire");
        // Check if each sprite is loaded correctly; log an error if any fail
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
        if (lightningSprite == null)
        {
            Debug.LogError("Failed to load lightning sprite. Check the file path and name.");
        }
        if (cupcakeSprite == null)
        {
            Debug.LogError("Failed to load cupcake sprite. Check the file path and name.");
        }
        if (diamondSwordSprite1 == null)
        {
            Debug.LogError("Failed to load Diamond Sword 1 sprite. Check the file path and name.");
        }
        if (dodgeBallSprite == null)
        {
            Debug.LogError("Failed to load dodgeball sprite. Check the file path and name.");
        }
        if (pizzaSprite == null)
        {
            Debug.LogError("Failed to load pizza sprite. Check the file path and name.");
        }
        if (sunflowerSprite == null)
        {
            Debug.LogError("Failed to load sunflower sprite. Check the file path and name.");
        }
        if (electricTreeSprite == null)
        {
            Debug.LogError("Failed to load electric tree sprite. Check the file path and name.");
        }
        if (explosionSprite == null)
        {
            Debug.LogError("Failed to load explosion sprite. Check the file path and name.");
        }
        if (spearSprite == null)
        {
            Debug.LogError("Failed to load spear sprite. Check the file path and name.");
        }
        if (fistSprite == null)
        {
            Debug.LogError("Failed to load fist sprite. Check the file path and name.");
        }
        if (electricitySprite == null)
        {
            Debug.LogError("Failed to load electric sprite. Check the file path and name.");
        }
        if (dualWieldSprite == null)
        {
            Debug.LogError("Failed to load dual wield sprite. Check the file path and name.");
        }
        if (freezeSprite == null)
        {
            Debug.LogError("Failed to load freeze sprite. Check the file path and name.");
        }
        if (gargantuaSprite == null)
        {
            Debug.LogError("Failed to load gargantua sprite. Check the file path and name.");
        }
        if (tentaclesSprite == null)
        {
            Debug.LogError("Failed to load tentacles sprite. Check the file path and name.");
        }
        if (sonicFlashSprite == null)
        {
            Debug.LogError("Failed to load sonic flash sprite. Check the file path and name.");
        }
        if (mysterySprite == null)
        {
            Debug.LogError("Failed to load mystery card sprite. Check the file path and name.");
        }
        if (spiderWebSprite == null)
        {
            Debug.LogError("Failed to load spider web sprite. Check the file path and name.");
        }
        if (supernovaSprite == null)
        {
            Debug.LogError("Failed to load supernova sprite. Check the file path and name.");
        }
        if (jellybeanSprite == null)
        {
            Debug.LogError("Failed to load jellybean sprite. Check the file path and name.");
        }
        if (potatoSprite == null)
        {
            Debug.LogError("Failed to load potato sprite. Check the file path and name.");
        }
        if (skullSprite == null)
        {
            Debug.LogError("Failed to load skull sprite. Check the file path and name.");
        }
        if (shieldSprite == null)
        {
            Debug.LogError("Failed to load shield sprite. Check the file path and name.");
        }
        if (wofSprite == null)
        {
            Debug.LogError("Failed to load wall of fire sprite. Check the file path and name.");
        }
        // Fireball cards are being added to the player deck.
        cardList.Add(new Card(0, "Fireball", 1, 300, "A deadly ball of fire.", fireballSprite));
        cardList.Add(new Card(1, "Uncommon Fireball", 1, 450, "A deadly ball of fire. Hits stronger.", fireballSprite));
        cardList.Add(new Card(2, "Rare Fireball", 1, 600, "A deadly ball of fire. Hits massively stronger.", fireballSprite));
        cardList.Add(new Card(3, "Epic Fireball", 1, 750, "A deadly ball of fire. Hits insanely stronger.", fireballSprite));
        cardList.Add(new Card(4, "Legendary Fireball", 1, 900, "A deadly ball of fire. Hits outrageously stronger.", fireballSprite));
        // Poison cards are being added to the player deck.
        cardList.Add(new Card(5, "Poison", 1, 200, "A bottle of poison.", poisonSprite));
        cardList.Add(new Card(6, "Uncommon Poison", 1, 300, "A bottle of poison. Hits stronger.", poisonSprite));
        cardList.Add(new Card(7, "Rare Poison", 1, 400, "A bottle of poison. Hits massively stronger.", poisonSprite));
        cardList.Add(new Card(8, "Epic Poison", 1, 500, "A bottle of poison. Hits insanely stronger.", poisonSprite));
        cardList.Add(new Card(9, "Legendary Poison", 1, 600, "A bottle of. Hits outrageously stronger.", poisonSprite));
        // Healing cards
        cardList.Add(new Card(10, "Heal", 1, 100, "A surge of healing.", healSprite));
        cardList.Add(new Card(11, "Uncommon Heal", 1, 200, "A strong surge of healing.", healSprite));
        cardList.Add(new Card(12, "Rare Heal", 1, 300, "A massive surge of healing.", healSprite));
        cardList.Add(new Card(13, "Epic Heal", 1, 400, "An insane surge of healing.", healSprite));
        cardList.Add(new Card(14, "Legendary Heal", 1, 500, "An outrageous surge of healing.", healSprite));
        // Additional card types: Hail
        cardList.Add(new Card(15, "Supernova", 2, 0, "Increases attack by +200 and decreases hp by -200 for ALL cards on the field.", supernovaSprite));
        // Jellybean
        cardList.Add(new Card(16, "Uncommon Jellybean", 2, 600, "Jellybeans. Hits stronger.", jellybeanSprite));
        cardList.Add(new Card(17, "Rare Jellybean", 2, 800, "Jellybeans. Hits massively stronger.", jellybeanSprite));
        cardList.Add(new Card(18, "Epic Jellybean", 2, 1000, "Jellybeans. Hits insanely stronger.", jellybeanSprite));
        cardList.Add(new Card(19, "Legendary Jellybean", 2, 1200, "Jellybeans. Hits insanely stronger.", jellybeanSprite));
        // Additional card types: Lightning
        cardList.Add(new Card(20, "Lightning", 3, 600, "A hard-hitting bolt of electricity strikes upon foes.", lightningSprite));
        cardList.Add(new Card(21, "Uncommon Lightining", 3, 900, "A hard-hitting bolt of electricity strikes upon foes. Hits stronger.", lightningSprite));
        cardList.Add(new Card(22, "Rare Lightning", 3, 1200, "A hard-hitting bolt of electricity strikes upon foes. Hits massively stronger.", lightningSprite));
        cardList.Add(new Card(23, "Epic Lightning", 3, 1500, "A hard-hitting bolt of electricity strikes upon foes. Hits insanely stronger.", lightningSprite));
        cardList.Add(new Card(24, "Legendary Lightning", 3, 1800, "A hard-hitting bolt of electricity strikes upon foes. Hits outrageously stronger.", lightningSprite));
        // Additional card types: Cupcake
        cardList.Add(new Card(25, "Cupcake", 1, 200, "What a nice tasty cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(26, "Uncommon Cupcake", 1, 400, "What a nice, strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(27, "Rare Cupcake", 1, 600, "What a nice, massively strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(28, "Epic Cupcake", 1, 800, "What a nice, insanely strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        cardList.Add(new Card(29, "Legendary Cupcake", 1, 1000, "What a nice, outrageously strong tasting cupcake! Mmm, yummy!", cupcakeSprite));
        // Diamond Sword
        cardList.Add(new Card(30, "Legendary Diamond Sword", 6, 6000, "It is unknown what this sword is made out of... Some people say it's diamond because it's blue and glossy.", diamondSwordSprite1));
        // Dodgeball
        cardList.Add(new Card(31, "Common Dodgeball", 2, 400, "Creates a satisfying SMACK soound.", dodgeBallSprite));
        cardList.Add(new Card(32, "Uncommon Dodgeball", 2, 600, "Creates a strong satisfying SMACK soound.", dodgeBallSprite));
        cardList.Add(new Card(33, "Rare Dodgeball", 2, 800, "Creates a massively satisfying SMACK soound.", dodgeBallSprite));
        cardList.Add(new Card(34, "Epic Dodgeball", 2, 1000, "Creates an insanely satisfying SMACK soound.", dodgeBallSprite));
        cardList.Add(new Card(35, "Legendary Dodgeball", 2, 1200, "Creates an outrageously satisfying SMACK soound.", dodgeBallSprite));
        // Pizza
        cardList.Add(new Card(36, "Common Pizza", 2, 300, "Mmm! Pizza!", pizzaSprite));
        cardList.Add(new Card(37, "Uncommon Pizza", 2, 450, "Mmm! Tasty Pizza!", pizzaSprite));
        cardList.Add(new Card(38, "Rare Pizza", 2, 600, "Mmm! Tastier Pizza!", pizzaSprite));
        cardList.Add(new Card(39, "Epic Pizza", 2, 750, "Mmm! Even Tastier Pizza!", pizzaSprite));
        cardList.Add(new Card(40, "Legendary Pizza", 2, 900, "Mmm! The Tastiest Pizza!", pizzaSprite));
        // Sunflower
        cardList.Add(new Card(41, "Common Sunflower", 1, 1, "Turns sunny for 1 turn.", sunflowerSprite));
        cardList.Add(new Card(42, "Uncommon Sunflower", 1, 2, "Turns sunny for 2 turns.", sunflowerSprite));
        cardList.Add(new Card(43, "Rare Sunflower", 1, 3, "Turns sunny for 3 turns.", sunflowerSprite));
        cardList.Add(new Card(44, "Epic Sunflower", 1, 4, "Turns sunny for 4 turns.", sunflowerSprite));
        cardList.Add(new Card(45, "Legendary Sunflower", 1, 5, "Turns sunny for 5 turns.", sunflowerSprite));
        // Electric Tree
        cardList.Add(new Card(46, "Rare Electric Tree", 3, 1, "Paralyzes someone for 1 turn.", electricTreeSprite));
        cardList.Add(new Card(47, "Epic Electric Tree", 3, 2, "Paralyzes someone for 2 turns.", electricTreeSprite));
        cardList.Add(new Card(48, "Legendary Electric Tree", 3, 3, "Paralyzes someone for 3 turns.", electricTreeSprite));
        // Explosion
        cardList.Add(new Card(49, "Epic Explosion", 6, 2500, "Explodes both sides!", explosionSprite));
        cardList.Add(new Card(50, "Legendary Explosion", 6, 3200, "Explodes both sides with an even bigger explosion!", explosionSprite));
        // Spears
        cardList.Add(new Card(51, "Uncommon Spear", 4, 2400, "A spear is thrown at someone.", spearSprite));
        cardList.Add(new Card(52, "Rare Spear", 4, 2800, "A strong spear is thrown at someone.", spearSprite));
        cardList.Add(new Card(53, "Epic Spear", 4, 3200, "A stronger spear is thrown at someone.", spearSprite));
        cardList.Add(new Card(54, "Legendary Spear", 4, 3600, "An even stronger spear is thrown at someone.", spearSprite));
        // Fists
        cardList.Add(new Card(55, "Common Fists", 1, 100, "Throw a punch!", fistSprite));
        cardList.Add(new Card(56, "Uncommon Fists", 1, 200, "Throw a strong punch!", fistSprite));
        cardList.Add(new Card(57, "Rare Fists", 1, 300, "Throw a massively strong punch!", fistSprite));
        cardList.Add(new Card(58, "Epic Fists", 1, 400, "Throw an insanely strong punch!", fistSprite));
        cardList.Add(new Card(59, "Legendary Fists", 1, 500, "Throw an outrageously strong punch!", fistSprite));
        // Electricity
        cardList.Add(new Card(60, "Uncommon Electricity", 5, 1500, "Gives the power of electricity.", electricitySprite));
        cardList.Add(new Card(61, "Rare Electricity", 5, 2300, "Gives a strong power of electricity.", electricitySprite));
        cardList.Add(new Card(62, "Epic Electricity", 5, 3000, "Gives a stronger power of electricity.", electricitySprite));
        cardList.Add(new Card(63, "Legendary Electricity", 5, 3800, "Gives an even stronger power of electricity.", electricitySprite));
        // Dual Wield Sword
        cardList.Add(new Card(64, "Epic Dual Wield Swords", 4, 2400, "Uses two swords.", dualWieldSprite));
        cardList.Add(new Card(65, "Legendary Dual Wield Swords", 4, 4800, "Uses two strong swords.", dualWieldSprite));
        // Freeze
        cardList.Add(new Card(66, "Rare Freeze", 2, 2, "A sudden chill enters the body...", freezeSprite));
        cardList.Add(new Card(67, "Epic Freeze", 2, 4, "A strong, sudden chill enters the body...", freezeSprite));
        cardList.Add(new Card(68, "Legendary Freeze", 2, 6, "A stronger, sudden chill enters the body...", freezeSprite));
        // Gargantua
        cardList.Add(new Card(69, "Gargantua", 10, 10000, "(Ultimate) (Fusion Card)", gargantuaSprite));
        // Ten tickles
        cardList.Add(new Card(70, "Rare Tentacles", 3, 700, "A slimy tentacle whacks the opponent!", tentaclesSprite));
        cardList.Add(new Card(71, "Epic Tentacles", 3, 1000, "A slimy tentacle whacks the opponent! Hits stronger.", tentaclesSprite));
        cardList.Add(new Card(72, "Legendary Tentacles", 3, 1400, "A slimy tentacle whacks the opponent! Hits massively stronger.", tentaclesSprite));
        // Sonic Flash
        cardList.Add(new Card(73, "Common Sonic Flash", 0, 100, "A ball is thrown at the speed of light!", sonicFlashSprite));
        cardList.Add(new Card(74, "Uncommon Sonic Flash", 0, 200, "A stronger ball is thrown at the speed of light!", sonicFlashSprite));
        cardList.Add(new Card(75, "Rare Sonic Flash", 0, 300, "A massively stronger ball is thrown at the speed of light!", sonicFlashSprite));
        cardList.Add(new Card(76, "Epic Sonic Flash", 0, 400, "An insanely stronger ball is thrown at the speed of light!", sonicFlashSprite));
        cardList.Add(new Card(77, "Legendary Sonic Flash", 0, 500, "An outrageously stronger ball is thrown at the speed of light!", sonicFlashSprite));
        // Mystery Card
        cardList.Add(new Card(78, "Common Mystery Card", 1, 0, "A random card at common rarity is played.", mysterySprite));
        cardList.Add(new Card(79, "Uncommon Mystery Card", 2, 0, "A random card at uncommon rarity is played.", mysterySprite));
        cardList.Add(new Card(80, "Rare Mystery Card", 3, 0, "A random card at rare rarity is played.", mysterySprite));
        cardList.Add(new Card(81, "Epic Mystery Card", 4, 0, "A random card at epic rarity is played.", mysterySprite));
        cardList.Add(new Card(82, "Legendary Mystery Card", 5, 0, "A random card at legendary rarity is played.", mysterySprite));
        // Spider Web
        cardList.Add(new Card(83, "Rare Spider Web", 1, 1, "Causes something to miss a turn", spiderWebSprite));
        cardList.Add(new Card(84, "Epic Spider Web", 1, 2, "Causes something to miss a turn", spiderWebSprite));
        cardList.Add(new Card(85, "Legendary Spider Web", 1, 3, "Causes something to miss a turn", spiderWebSprite));
        // Potato
        cardList.Add(new Card(86, "Potato of Death", 0, 0, "Does nothing.", potatoSprite));
        // Skull
        cardList.Add(new Card(87, "Skull", 0, 0, "Does nothing.", skullSprite));
        // Shield
        cardList.Add(new Card(88, "Common Shield", 1, 100, "A shield is placed in front that can take 100 damage.", shieldSprite));
        cardList.Add(new Card(89, "Uncommon Shield", 1, 200, "A shield is placed in front that can take 200 damage.", shieldSprite));
        cardList.Add(new Card(90, "Rare Shield", 1, 300, "A shield is placed in front that can take 300 damage.", shieldSprite));
        cardList.Add(new Card(91, "Epic Shield", 1, 400, "A shield is placed in front that can take 400 damage.", shieldSprite));
        cardList.Add(new Card(92, "Legendary Shield", 1, 500, "A shield is placed in front that can take 500 damage.", shieldSprite));
        // Wall of Fire
        cardList.Add(new Card(93, "Uncommon Wall of Fire", 2, 200, "A wall of fire is placed in front that can take 200 damage, and burns the attacker.", wofSprite));
        cardList.Add(new Card(94, "Rare Wall of Fire", 2, 400, "A wall of fire is placed in front that can take 400 damage, and burns the attacker.", wofSprite));
        cardList.Add(new Card(95, "Epic Wall of Fire", 2, 600, "A wall of fire is placed in front that can take 600 damage, and burns the attacker.", wofSprite));
        cardList.Add(new Card(96, "Legendary Wall of Fire", 2, 800, "A wall of fire is placed in front that can take 800 damage, and burns the attacker.", wofSprite));
    }
}