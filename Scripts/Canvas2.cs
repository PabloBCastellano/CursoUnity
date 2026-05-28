using System;
using System.Data;
using TMPro.EditorUtilities;
using UnityEngine;

public class Canvas2 : MonoBehaviour
{
    //Mostrar los Pares dado un rango
    [SerializeField, Range(0, 100)] int NumEntrada;
    [SerializeField] TMPro.TMP_Text Resultado;
    void Awake()
    {
        Resultado.alignment = TMPro.TextAlignmentOptions.Center;


        if (EsMultiplo2(NumEntrada))
        {
            Resultado.color = Color.magenta;
            Resultado.text = $"El Numero {NumEntrada} es Multiplo de 2";
        }

    }

    bool EsMultiplo2(int NumEntrada)
    {
        return NumEntrada % 2 == 0;
    }

}
