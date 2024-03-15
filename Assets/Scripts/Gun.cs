using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public override void Fire()
    {
        Debug.Log("Disparando: GUN!");
    }

    public void meleeImpact()
    {
        Debug.Log("Golpeaste al enemigo con la pistola");
    }
}
