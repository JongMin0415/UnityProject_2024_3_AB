using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private int index;
    private string name;
    private ItemType itemType;
    private Sprite image;
}

public enum ItemType
{
    Weapon,
    Armor,
    Potion,
    QuestItem
}
