using System;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.Android.Gradle;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class LayOut1 : MonoBehaviour
{
    /*Crear un horizontal layout donde pueden añadirse círculos (prefab) de manera dinámica, 2 botones (uno con texto “+” y
 otro “-”) de manera que al pulsar el botón “+” se añada un círculo y pulsando “-” se quite un círculo.
 1. Inicialmente con 3 círculos
 2. El número mínimo de círculos es 0 y si se intentan quitar círculos cuando no hay se muestra un error “Operación no posible”*/

    [SerializeField] GameObject Prefabs;
    [SerializeField] RectTransform PadreTransform;
    public List<GameObject> ListaObjetos;

    void Awake()
    {
        if (Prefabs == null)
        {
            throw new Exception("No existen prefabs");
            //ListaObjetos = new List<GameObject>();
        }
    }
    public void AñadirCirculo()
    {
        //Vamos a Instanciar mediante el metodo Instanciate
        var Elemento = Instantiate(Prefabs, PadreTransform);
        ListaObjetos.Add(Elemento);


    }
    public void QuitarCirculo()
    {

        if (ListaObjetos.Count > 0)
        {
            var SacarLista = ListaObjetos[0];
            ListaObjetos.Remove(SacarLista);
            Destroy(SacarLista);
        }
    }
}