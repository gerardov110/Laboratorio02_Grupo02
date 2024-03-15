using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryItem
{
    string Name { get; }
    void Use();
}

public interface IWeapon : IInventoryItem
{
    int Damage { get; }
    void Attack();
}

public interface IArmor : IInventoryItem
{
    int Defense { get; }
    ArmorType Type { get; }
}

public enum ArmorType
{
    Helmet,
    Chestplate,
    Leggings,
    Boots
}

public interface IPotion : IInventoryItem
{
    PotionEffect Effect { get; }
    void Drink();
}

public enum PotionEffect
{
    HealthRestoration,
    ManaRestoration,
    StrengthEnhancement
}
