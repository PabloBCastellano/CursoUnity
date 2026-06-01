using System;
using TMPro;
using UnityEngine;

public class Canvas3 : MonoBehaviour
{
    // Dados dos números, ordenarlos usando los símbolos <,>,= y dos
    // métodos (EsIgual, EsMenor) que compare los 2 números y
    // mostrar la respuesta con un TMP_Text
    [SerializeField] float numero1 = 5.3f;
    [SerializeField] float numero2 = -10;
    [SerializeField] TMP_Text tMP_Text;

    void Awake()
    {
        if (tMP_Text == null)
            throw new Exception("ERROR: falta texto");

        if (EsMenor(numero1, numero2))
            tMP_Text.text = $"{numero1} < {numero2}";
        else
            if (EsIgual(numero1, numero2))
                tMP_Text.text = $"{numero1} = {numero2}";
            else
                tMP_Text.text = $"{numero1} > {numero2}";

        tMP_Text.fontSize = 14.5f;
        tMP_Text.alignment = TextAlignmentOptions.Center;
    }

    bool EsMenor(float n1, float n2)
    {
        return n1 < n2;
    }

    bool EsIgual(float n1, float n2)
    {
        return n1 == n2;
    }
}
