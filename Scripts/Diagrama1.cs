
using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Diagrama1 : MonoBehaviour
{
    /* Implementar un programa que cumpla el diseño dado por este diagrama de
estados La cantidad solicitada la modificará el usuario en una variable del Script
Con Estados y Texto para mostrar la deuda que tienes aun
P procesar
A aceptar
R rechazar
D depositar al cliente*/

    [SerializeField, Range(0, 7000)] float Prestamo, CantidadPagada;
    [SerializeField] TMPro.TMP_Text DeudaPendiente, EstadoActual;
    [SerializeField] Button BotonPagar;
    [SerializeField] TMP_InputField EntradaDinero;
    bool PagoTotal = false;
    enum EstadoPrestamo
    {
        Solicitado, EnRevision, Aceptado, Rechazado, Entregado, Pagado
    }
    EstadoPrestamo SituacionPeticion;
    void Awake()
    {
        DeudaPendiente.alignment = TMPro.TextAlignmentOptions.Center;
        DeudaPendiente.fontSize = 30;
        EstadoActual.alignment = TMPro.TextAlignmentOptions.Center;
        EstadoActual.fontSize = 30;
        SituacionPeticion = EstadoPrestamo.Solicitado;
        EstadoActual.text = SituacionPeticion.ToString();
        BotonPagar.gameObject.SetActive(false);
        EntradaDinero.gameObject.SetActive(false);
        EntradaDinero.textComponent.fontSize = 30;
        EntradaDinero.textComponent.fontStyle = TMPro.FontStyles.Normal;
        EntradaDinero.textComponent.alignment = TMPro.TextAlignmentOptions.Center;

    }

    void Update()
    {
        switch (SituacionPeticion)
        {
            case EstadoPrestamo.Solicitado:

                if (Input.GetKeyDown(KeyCode.P))
                {

                    SituacionPeticion = EstadoPrestamo.EnRevision;
                    EstadoActual.text = SituacionPeticion.ToString();

                }
                break;

            case EstadoPrestamo.EnRevision:

                if (Input.GetKeyDown(KeyCode.A))
                {
                    SituacionPeticion = EstadoPrestamo.Aceptado;
                    EstadoActual.text = SituacionPeticion.ToString();
                    DeudaPendiente.text = Prestamo.ToString();
                    BotonPagar.gameObject.SetActive(true);
                    EntradaDinero.gameObject.SetActive(true);

                }
                else if (Input.GetKeyDown(KeyCode.R))
                {
                    SituacionPeticion = EstadoPrestamo.Rechazado;
                    EstadoActual.text = SituacionPeticion.ToString();

                }
                break;



            case EstadoPrestamo.Aceptado:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    SituacionPeticion = EstadoPrestamo.Entregado;
                    EstadoActual.text = SituacionPeticion.ToString();
                }
                break;


        }
    }

    public void DevolverPrestamo()
    {
        //Devuelve el texto del InputField
        EstadoActual.text = null;

        try
        {
            CantidadPagada = float.Parse(EntradaDinero.text);
            if (CantidadPagada > 0 & CantidadPagada < Prestamo)
            {
                Debug.Log(EntradaDinero.GetComponent<TMP_InputField>().text);
                DeudaPendiente.text = $" Debes {Prestamo - CantidadPagada} €";
                Prestamo -= CantidadPagada;
                EntradaDinero.text = Prestamo.ToSafeString();
            }
            else if (CantidadPagada >= Prestamo)
            {
                DeudaPendiente.text = "Deuda Pagada";
                EstadoActual.text = "Pagado";
                BotonPagar.gameObject.SetActive(false);
                EntradaDinero.gameObject.SetActive(false);
                SituacionPeticion = EstadoPrestamo.Pagado;

            }

        }
        catch
        {
            throw new Exception("NO es posible realizar la conversion");
        }
    }
}
