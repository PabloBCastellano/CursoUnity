

using System.Collections;
using UnityEngine;

public class Corrutinas1 : MonoBehaviour
{ /*Dado un número, mostrar con TMP_Text los números desde el 1 hasta el número ingresado usando corrutinas IEnumerator, los
números avanzan con un retardo de tiempo indicado por el usuario*/

    [SerializeField] int NumeroEntrada;
    [SerializeField] TMPro.TMP_Text Salida;
    [SerializeField, Range(0.1f, 5f)] float TiempoEspera;
    void Start()
    {
        Salida.alignment = TMPro.TextAlignmentOptions.Center;
        Salida.fontSize = 30;
        StartCoroutine(UsarCorrutina());




    }
    IEnumerator UsarCorrutina()
    {
        for (int i = 1; i <= NumeroEntrada; i++)
        {
            if (i == NumeroEntrada)
            {

                Salida.text = $" {i}";
                yield return new WaitForSeconds(TiempoEspera);

            }
            else
            {
                Salida.text = $" {i},";
                yield return new WaitForSeconds(TiempoEspera);
                // yield return null Espera 1 fotograma
                //yield break Corta la Corrutina
            }
        }

    }


}
