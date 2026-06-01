using System;
using UnityEngine;

public class Componentes1 : MonoBehaviour
{
    // Dado un array de GameObjects, activar solo el primero y el último

    public GameObject[] gos;

    void Awake()
    {
        if (gos.Length == 0)
            throw new Exception("ERROR: array vacío");

        //desactivo a todos
        foreach (var go in gos)
        {
            go.SetActive(false);
        }

        // activo el primero
        gos[0].SetActive(true);
        // activo el último
        gos[gos.Length - 1].SetActive(true);
    }
}
