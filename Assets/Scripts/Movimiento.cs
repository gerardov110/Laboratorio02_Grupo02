using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField] private float velocidad = 15;


    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 movimiento = new Vector2(h, v);

        GetComponent<Rigidbody2D>().velocity = movimiento * velocidad;
    }
}
