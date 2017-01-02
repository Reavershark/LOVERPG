using UnityEngine;
public class itemDB : MonoBehaviour{


    //| Item name | Sprite name | Description | Loadout power | Item type | Effect | var1
    //
    // Available item types:
    // potion, dummy
    //
    // Item effects:
    // singleHeal(1=healAmount), allHeal(1=healAmount), singleRes, remSleep, remStun, remCharm, singleMHeal
    //
    // Copy/Paste:
    // new string[] {"name", "sprite", "descr", "power", "type", "var1"},

    
    public string[][] itemsDB = new string[][]
    {
    
        new string[] {"Red Potion", "", "A potion that restores 50 HP", "5", "potion", "singleHeal", "50"},
        new string[] {"Big Red Potion", "", "A potion that restores 70 HP", "11", "potion", "singleHeal", "70"},
        new string[] {"Bright Red Potion", "", "A potion that restores max HP", "40", "potion", "singleHeal", "1000000"},
        new string[] {"Red Flower", "", "A beautyfull Red flower (Pittoyye's first item, how cute :3)", "0", "dummy", "", ""},
        new string[] {"Blue Potion", "", "A potion that restores 25 MP", "5", "Potion", "singleMHeal", "25"},
        new string[] {"Big Blue Potion", "", "A potion that restores 40 MP", "11", "Potion", "singleMHeal", "40"}
        new string[] {"Bright Blue potion", "", "A potion that restores max MP", "50", "potion", "singleMHeal", "1000000"},
    };



    //| Piece name | Sprite name | Description | Loadout power | Piece type | Pdmg | Mdmg | Def | mDef | STA(max hp & block rate) | INT(mDmg & max mp) | STR(Pdmg) | AGI(speed & evasion rate) | SPR(mDef & crit rate) |
    //
    // Available piece types:
    // 1HMelee, 2HMelee, 1HRanged, 2HRanged, 1HMagic, 2HMagic, shield
    // head, chest, legs, shoes
    // ring, necklace, earring, wristband
    //
    // Copy/Paste:
    // new string[] {"name", "sprite", "descr", "power", "type", "Pdmg", "Mdmg", "Def", "mDef", "STA", "INT", "STR", "AGI", "SPR"},
    
    public string[][] equipmentDB = new string[][]
    {
    
        new string[] {"Wooden Sword", "", "A basic wooden sword", "10", "1HMelee", "5", "0", "0", "0", "0", "0", "3", "2", "0"},
        new string[] {"Copper Sword", "", "A dull copper sword", "15", "1HMelee", "7", "0", "0", "0", "0", "0", "4", "3", "0"},
        new string[] {"Iron Sword", "", "A plain normal iron sword", "30", "1HMelee", "12", "0", "0", "0", "2", "0", "7", "5", "4"},
        new string[] {"Wooden Longsword", "", "Basically a long stick", "15", "2HMelee", "7", "0", "0", "0", "0", "0", "5", "0", "0"},
        new string[] {"Copper Longsword", "", "A longer copper sword", "20", "2HMelee", "12", "0", "0", "0", "1", "0", "8", "2", "1"},
        new string[] {"Iron Longsword", "", "A longer iron sword", "40", "2HMelee", "17", "0", "0", "0", "4", "", "12", "4", "3"},
        new string[] {"Plastic Wand", "", "What kind of wand do u mean( ?° ?? ?°)", "12", "1HMagic", "2", "6", "0", "0", "1", "3", "1", "4", "2"},
        new string[] {"Wooden Saphire wand", "", "Im feeling Blue", "18", "1HMagic", "3", "9", "0", "0", "1", "5", "1", "5", "4"},
        new string[] {"Wooden Ruby wand", "", "Im feeling Red", "18", "1HMagic", "3", "9", "0", "0", "1", "5", "1", "5", "4"},
        new string[] {"Wooden Emerald wand", "", "Im feeling Green", "18", "1HMagic", "3", "9", "0", "0", "1", "5", "1", "5", "4"},
        new string[] {".???..?.??", "", "Mithic gold plated titanium magic with uranium wand core wand", "330", "2HMagic", "69", "69", "69", "69", "69", "69", "69", "69", "69"},
            new string[] {"Old Leather Cap", "", "A worn leather cap", "4", "head", "0", "0", "3", "2", "1", "0", "0", "4", "2"}
            new string[] {"Old Leather Shirt", "", "A worn leather shirt", "6", "chest", "0", "0", "5", "4", "1", "0", "0", "4", "2"},
            new string[] {"Old Leather Pants", "", "A worn leather pants", "5", "legs", "0", "0", "4", "2", "0", "0", "0", "3", "2"},
            new string[] {"Old Leather Boots", "", "Some worn leather boots", "3", "shoes", "0", "0", "2", "1", "0", "0", "0", "2", "1"},
            new string[] {"Silly Band", "", "You feel fabulous", "1", "wristband", "0", "0", "0", "0", "0", "0", "0", "0", "2"},
            new string[] {"Rusty Necklace", "", "Hope u don't get tetanus", "3", "necklace", "0", "0", "0", "1", "2", "1", "1", "1", "1"},
            new string[] {"Rusty Ring", "", "Wear it like u just don't care", "2", "ring", "0", "0", "2", "1", "0", "0", "1", "0", "0"},
            new string[] {"Rusty Earring", "", "Waw u want to be sick don't you", "1", "earring", "0", "0", "0", "0", "0", "2", "0", "0", "0"},
    };









    //| Spell name | Sprite name | Description | Loadout power | 
    //
    // Available spell types:
    // single, AOE
    //
    //
    // Spell effects: 
    // damage (1=Dmg), lightningDamage(1=Dmg, 2=wetMultiplier), damageSelfAndDamage(1=selfDmg, 2=dmg)
    // burn (1=duration), burnAndDamage(1=duration, 2=Dmg), slow(1=Duration), slowAndDamage, wet, wetAndDamage
    //
    // Examples:
    // burnAndDamage = burn effect + deal damage
    // lightningDamage = more damage on wet targets
    // damageSelfAndDamage(1=selfDmg, 2=dmg) means that var1 = the amount of damage to self, var2 = the amount of damage to target
    //
    //
    // Copy/Paste:
    // new string[] {"name", "sprite", "descr", "power", "type", "cost"", "var1", "var2"},
    
    public string[][] spellsDB = new string[][] 
    {
    
        new string[] {"FireBall", "", "A ball of fire that hits a single target", "15", "burnAndDamage","5"},
        new string[] {"Chain Lightning", "", "A lightning strike that chains to nearby enemies around the target, dealing less damage", "lightningDamage", "1"},
        new string[] {"Berserk Slash", "", "Deal massive damage, also wounding the attacker", "30", "damageSelfAndDamage", "10", "25"}
        
    };
    
    
    
    // Effect name | Sprite name | Description
    // Copy/Paste:
    // new string[] {"name", "sprite", "descr"},
    
    public string[][] buffsDB = new string[][]
    {
        new string[] {"Burn", "", "A burning effect that causes damage over time"}
    };
}