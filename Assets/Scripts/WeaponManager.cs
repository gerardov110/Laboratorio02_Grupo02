using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public void executeWeapon(Weapon weapon)
    {
        weapon.Fire();
    }
}
