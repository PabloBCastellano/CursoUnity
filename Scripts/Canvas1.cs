using UnityEngine;

public class Canvas1 : MonoBehaviour
{
    // Dado un número, mostrar la suma de los números que 
    // lo anteceden hasta el 0 en un TMP_Text. 
    // Lanzar excepción si el número es negativo o 
    // si no asignaste el Texto

    [SerializeField] int numero = 7;
    [SerializeField] TMPro.TMP_Text tMP_Text;

    void Awake()
    {
        if (numero < 0 | tMP_Text == null)
            throw new System.Exception("ERROR: datos no válidos");

        var suma = 0f;

        for (int i = 0; i < numero; i++)
        {
            suma += i;
        }

        // Debug.Log($"La suma vale {suma}");
        tMP_Text.text = $"La suma vale {suma}";
    }
}
