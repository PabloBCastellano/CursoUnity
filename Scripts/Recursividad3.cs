using UnityEngine;

public class Recursividad3 : MonoBehaviour
{
    /*  Dado un número N, sumar los números naturales hasta N de
forma recursiva.*/
    [SerializeField] int NumInicio, NumFinal;
    int Suma = 0;
    void Awake()
    {
        SumarNumeros(NumInicio);
    }

    void SumarNumeros(int Inicio)
    {
        if (Inicio == NumFinal)
        {
            Debug.Log($"{Suma += Inicio}");
            return;
        }

        SumarNumeros(Inicio + 1);
        Debug.Log($"{Suma += Inicio}");

    }
}
