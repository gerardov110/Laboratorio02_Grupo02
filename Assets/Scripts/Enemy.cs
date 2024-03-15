using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public virtual void Move()
    {
        // L�gica de movimiento gen�rica para todos los enemigos del juego
    }

    public virtual void Attack()
    {
        // L�gica de ataque gen�rica para todos los enemigos del juego
    }
}

public class NormalEnemy : Enemy
{
    public override void Move()
    {
        // L�gica de movimiento espec�fica para los enemigos normales
    }

    public override void Attack()
    {
        // L�gica de ataque espec�fica para los enemigos normales
    }
}

public class BossEnemy : Enemy
{
    public override void Move()
    {
        // L�gica de movimiento espec�fica para el jefe enemifo
    }

    public override void Attack()
    {
        // L�gica de ataque espec�fica para el jefe enemigo
    }
}
