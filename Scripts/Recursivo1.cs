using UnityEngine;

public class Recursivo1 : MonoBehaviour
{
    //Escribir los números del 1 al 10 usando recursividad.
    void Awake()
    {

        VersionRecursiva1(1);

    }
    //Vamos a Crear una funcion recursiva

    void VersionRecursiva1(int veces)
    {

        if (veces == 10)
        {
            Debug.Log(veces);
            return;
        }

        Debug.Log(veces);
        VersionRecursiva1(veces + 1);
        /* Imprime al reves la funcion
        Debug.Log(veces);*/

    }

}
