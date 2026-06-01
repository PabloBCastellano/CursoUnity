using System;

using UnityEditor;
using UnityEngine;

public class Componentes8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject[] ListObjetos;

    void Awake()
    {
        if (ListObjetos.Length == 0)
        {
            throw new Exception("NO Hay datos para evaluar");
        }
        else if (ListObjetos[0].GetComponent<SpriteRenderer>() & ListObjetos[1].GetComponent<SpriteRenderer>()) { }
        {
            SpriteRenderer sp = ListObjetos[0].GetComponent<SpriteRenderer>();
            SpriteRenderer sp1 = ListObjetos[1].GetComponent<SpriteRenderer>();
            Debug.Log(sp.name);
            //Con esto obtienes el nombre del spriteRender 
            // sp.sortingLayerName = ListObjetos[0].name;
            // sp1.sortingLayerName = ListObjetos[1].;
            sp.sortingOrder = 2;
            sp1.sortingOrder = 3;

        }

    }
}
