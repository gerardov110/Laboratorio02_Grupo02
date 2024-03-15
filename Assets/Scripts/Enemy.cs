using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public virtual void Move()
    {
        // Lógica de movimiento genérica para todos los enemigos del juego
    }

    public virtual void Attack()
    {
        // Lógica de ataque genérica para todos los enemigos del juego
    }
}

public class NormalEnemy : Enemy
{
    public override void Move()
    {
        // Lógica de movimiento específica para los enemigos normales
    }

    public override void Attack()
    {
        // Lógica de ataque específica para los enemigos normales
    }
}

public class BossEnemy : Enemy
{
    public override void Move()
    {
        // Lógica de movimiento específica para el jefe enemifo
    }

    public override void Attack()
    {
        // Lógica de ataque específica para el jefe enemigo
    }
}
