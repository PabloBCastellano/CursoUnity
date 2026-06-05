using System.Collections;
using UnityEngine;

public class Recursividad5 : MonoBehaviour
{
    /*Crear llamadas recursivas mediante corrutinas con tiempo de espera de 2 segundos.
     1. Vemos que la 1a llamada acaba 6 segundos, la 2a a los 4 segundos y la 3a a los 2 segundos*/

    void Start()
    {
        StartCoroutine(Rutinas(1));
    }

    IEnumerator Rutinas(int repeticiones)
    {
        //Time.Time te muestra cuando se inicio la aplicacion
        /*Time.TimeScale tiene que ver con la velocidad de reproduccion .Para todo lo que se esta ejecutando
        Time.timescale=0.1f*/
        //Time.realTime te muestra en secundos el tiempo de ejecucion real .
        if (repeticiones == 4)
        {
            yield break;
        }
        //Debug.Log($"Tiempo en llamarse {repeticiones} -> {Time.time}");
        yield return new WaitForSeconds(2);
        StartCoroutine(Rutinas(repeticiones + 1));
        /*Con return StartCoroutine espera que la actual acabe para empezar la sigiuente
        yield return StartCoroutine(Rutinas(repeticiones + 1));*/
        // yield return StartCoroutine(Rutinas(repeticiones + 1));
        Debug.Log($"Tiempo en llamarse {repeticiones} -> {Time.time}");
    }
}
