using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : IWeapon
{
    public string Name { get; private set; }
    public int Damage { get; private set; }

    public Sword(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void Use()
    {
        Attack();
    }

    public void Attack()
    {
        Console.WriteLine($"Usando la {Name}, haciendo {Damage} de daño.");
    }
}

public class Breastplate : IArmor
{
    public string Name { get; private set; }
    public int Defense { get; private set; }
    public ArmorType Type { get; private set; }

    public Breastplate(string name, int defense)
    {
        Name = name;
        Defense = defense;
        Type = ArmorType.Chestplate;
    }

    public void Use()
    {
        Console.WriteLine($"Equipando {Name}, obteniendo {Defense} de defensa.");
    }
}

public class HealthPotion : IPotion
{
    public string Name { get; private set; }
    public PotionEffect Effect { get; private set; }

    public HealthPotion(string name)
    {
        Name = name;
        Effect = PotionEffect.HealthRestoration;
    }

    public void Use()
    {
        Drink();
    }

    public void Drink()
    {
        Console.WriteLine($"Tomando {Name}, restaurando salud.");
    }
}
