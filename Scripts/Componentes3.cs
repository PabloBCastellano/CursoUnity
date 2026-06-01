using System;
using UnityEngine;

public class Componentes3 : MonoBehaviour
{
    // Dado un array de objetos con gravedad (Rigidbody2D), 
    //      activar solo aquellos cuyo índice es múltiplo de 3
    //      Dado el componente accedemos a su Gameobject
    [SerializeField] Rigidbody2D[] rigidbody2Ds;

    void Awake()
    {
        if (rigidbody2Ds.Length == 0) throw new Exception("ERROR: array vacío");

        for (int index = 0; index < rigidbody2Ds.Length; index++)
        {
            bool esMultiploDe3 = index % 3 == 0;
            // rigidbody2Ds[index].gravityScale 
            rigidbody2Ds[index].gameObject.SetActive(esMultiploDe3);
        }
    }
}
