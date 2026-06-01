using System;
using TMPro;
using UnityEngine;

public class Canvas2 : MonoBehaviour
{
    // Dado un número, crear un método para indicar si 
    //      un número es múltiplo de 2, mostrando la 
    //      respuesta con un TMP_Text
    [SerializeField, Range(0, 100)] int numero = 7;
    [SerializeField] TMP_Text tMP_Text;

    void Awake()
    {
        if (tMP_Text == null)
            throw new Exception("ERROR: texto vacío");

        if (EsMultiploDe2())
        {
            tMP_Text.alignment = TextAlignmentOptions.BottomRight;
            tMP_Text.fontSize = 20.5f;
            tMP_Text.text = $"El número {numero} es múltiplo de 2";
            tMP_Text.color = Color.grey;
        }
        else
        {
            tMP_Text.fontSize = 10f;
            tMP_Text.alignment = TextAlignmentOptions.BottomLeft;
            tMP_Text.text = $"El número {numero} no es múltiplo de 2";
            tMP_Text.color = Color.red;
        }
    }

    bool EsMultiploDe2()
    {
        return numero % 2 == 0;
    }
}
