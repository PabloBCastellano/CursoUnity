using System;

using UnityEngine;
using UnityEngine.UI;

public class LayOut2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image[] ConjuntoImagenes;
    public RectTransform Paternidad;

    void Awake()
    {
        if (ConjuntoImagenes.Length == 0)
        {
            throw new Exception("No se han encontrado Imagenes");
        }

        foreach (var Imagenes in ConjuntoImagenes)
        {
            //Esto crea una paternidad
            Imagenes.transform.SetParent(Paternidad);
        }
    }
}
