using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyMachineGun : Weapon
{
    public override void Fire()
    {
        Debug.Log("Disparando: HEAVYMACHINEGUN!!!");
    }
    public void Overheat()
    {
        Debug.Log("La HeavyMachineGun se sobrecalento, no puedes disparar");
    }
}
