using System;
using UnityEngine;
/*Dado un GameObject, comprobar si tiene Rigidbody2D, cambiar
su gravedad a 10 y lanzar una excepción cuando no la tenga*/
public class ComponenteGravedad : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject Objectos;
    void Awake()
    {
        if (Objectos == null)
        {
            throw new Exception("Necesito que agregues componentes");
        }
        //Si es un gameObject
        var Rigidbody2D = Objectos.GetComponent<Rigidbody2D>();
        if (Rigidbody2D == null)
        {
            throw new Exception("NO has arrastrado un RightedBody2D");
        }
        else
        {
            Rigidbody2D.gravityScale = 10;
            //Cambia la gravedad a Derecha Izquierda
            //Physics2D.gravity = new Vector2(-2, 5);
        }

    }
}
