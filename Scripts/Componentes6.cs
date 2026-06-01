using System;
using UnityEngine;

public class Componentes6 : MonoBehaviour
{
    public GameObject[] gameObjects;

    void Awake()
    {
        // Dado un array de GameObject, activar solo los que tengan 
        //      componente Rigidbody2D, si está vacío lanzar excepción. 
        //      Debemos usar estructura foreach.
        if (gameObjects.Length == 0)
            throw new Exception("ERROR: array vacío");

        foreach (var gameObject in gameObjects)
        {
            bool tieneRigidbody2D = gameObject.GetComponent<Rigidbody2D>() != null;
            gameObject.SetActive(tieneRigidbody2D);
        }
    }
}
