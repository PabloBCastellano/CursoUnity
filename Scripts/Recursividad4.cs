using UnityEngine;

public class Recursividad4 : MonoBehaviour
{
    /*Dado un número N y una potencia P, calcula la potencia de un numero de forma recursiva.*/

    [SerializeField] int Base, Potencia;
    int ResultadoPotencia = 1;
    void Awake()
    {
        //La Potencia empieza en 0
        PotenciaRecursiva(0);
        Debug.Log(ResultadoPotencia);
    }

    void PotenciaRecursiva(int repeticion)
    {
        if (repeticion == Potencia)
            return;

        ResultadoPotencia *= Base;
        Debug.Log(ResultadoPotencia);
        PotenciaRecursiva(repeticion + 1);
    }
}
