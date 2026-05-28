using UnityEngine;
using UnityEngine.UI;

public class Diagramas1 : MonoBehaviour
{
    //Crear un texto donde meter texto y que te devuelva adios

    [SerializeField] TMPro.TMP_Text TextoEntrada;


    enum EstadosBoton
    {
        Hola, Adios
    }
    EstadosBoton AccionBoton;
    void Awake()
    {
        AccionBoton = EstadosBoton.Hola;
        TextoEntrada.text = AccionBoton.ToString();

    }

    public void ActivarBoton()
    {
        switch (AccionBoton)
        {
            case EstadosBoton.Hola:
                TextoEntrada.text = "Adios";
                AccionBoton = EstadosBoton.Adios;
                TextoEntrada.color = Color.yellow;
                break;
            case EstadosBoton.Adios:
                AccionBoton = EstadosBoton.Hola;
                TextoEntrada.text = "Hola";
                TextoEntrada.color = Color.red;
                break;
        }
    }
}

