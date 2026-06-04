using System.Collections;
using UnityEngine;

public class Corrutinas2 : MonoBehaviour
{
    /*
    Usando el Ejemplo de corrutina Fade (Módulo 7), crear un Flicker, es decir, suba y 
    baje la opacidad un número de veces y en un tiempo indicado por el usuario.*/
    [SerializeField] new Renderer ColorObjeto;
    [SerializeField] new float TiempoEspera;
    [SerializeField] new int NumeroVeces;

    //Empezamos la corrutina
    void Awake()
    {


        StartCoroutine(Opacidad());


        //Otra Forma de llamar a un metodo
        //StartCoroutine(nameof(Opacidad));

    }


    IEnumerator Opacidad()
    {
        for (int veces = 1; veces <= NumeroVeces; veces++)
        {
            Debug.Log(veces);
            for (float num = 1f; num >= 0; num -= 0.1f)
            {
                Color c = ColorObjeto.material.color;
                c.a = num;
                ColorObjeto.material.color = c;
                yield return new WaitForSeconds(TiempoEspera);
                Color final = ColorObjeto.material.color;
                final.a = 0f;
                ColorObjeto.material.color = final;
            }
            StartCoroutine(DarLuz());

        }
        //yield break; //Opcional para terminar explícitamente la corrutina
    }
    //Vamos a hacer que aparezca otra vez
    IEnumerator DarLuz()
    {
        for (float val = 0f; val <= 1f; val += 0.1f)
        {
            Color c = ColorObjeto.material.color;
            c.a = val;
            ColorObjeto.material.color = c;
            yield return new WaitForSeconds(TiempoEspera);
            Color final = ColorObjeto.material.color;
            final.a = 1f;
            ColorObjeto.material.color = final;
        }
    }




}
