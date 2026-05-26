using System;
using System.Reflection;
using UnityEngine;

public class Canvas1 : MonoBehaviour
{
    [SerializeField] int Num = 7;

    //Es una malla que permite trabajar con textos y estilos
    [SerializeField] TMPro.TMP_Text TextoEntrada;


    void Awake()
    {
        //Herencia: Permite acceder a propiedadess de padres y usarlos en otras clases .Solo se puede evitar que haya herencia con sealed


        if (Num < 0 | TextoEntrada == null)
        {
            throw new Exception("Datos No validos o texto en Blanco");
        }
        else
        {
            var Numero = 0f;
            for (int i = 0; i < Num; i++)
            {
                Numero += i;

                //Con TMP_Text.text te muestra el mensaje en la pantalla de juego directamente

            }

            TextoEntrada.text = $"La Suma vale {Numero}";
        }
    }

}
