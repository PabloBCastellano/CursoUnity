
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;


/*
Dados dos números, ordenarlos usando los símbolos <,>,= y dos
métodos (EsIgual, EsMenor) que compare los 2 números y
mostrar la respuesta con un TMP_Text*/

public class Canvas4 : MonoBehaviour
{
    [SerializeField] float Num1, Num2;
    [SerializeField] TMPro.TMP_Text Resultado;
    void Awake()
    {
        Resultado.alignment = TMPro.TextAlignmentOptions.Center;
        Resultado.fontSize = 30;
        if (EsMenor(Num1, Num2))
        {
            Resultado.text = $"{Num1} < {Num2}";
        }
        else if (EsIgual(Num1, Num2))
        {
            Resultado.text = $"{Num1} = {Num2}";
        }
        else
        {
            Resultado.text = $"{Num1} > {Num2}";
        }

        /*
    }

    public void EsMayorMenor(float Num1, float Num2)
    {
        if (Num1 > Num2 | Num2 < Num1)
        {
            Resultado.text = $"{Num1} > {Num2}";
        }
        else if (Num1 < Num2 | Num2 > Num1)
        {
            Resultado.text = $"\n {Num2} > {Num1}";
        }
        else
        {
            Resultado.text = $"\n {Num1} = {Num2}";
        }
        */
    }

    bool EsMenor(float Num1, float Num2)
    {
        return Num1 < Num2;
    }
    bool EsIgual(float Num1, float Num2)
    {
        return Num1 == Num2;
    }

}
