using System;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Diagramas8 : MonoBehaviour
{
    /*Se creará un número de vidas basado en un
SpriteRenderer configurado para poder repetirse (tiled) y dos
botones, uno para decrementar y otro para incrementar el
número de vidas en 1. Inicialmente hay 3 vidas.*/

    [SerializeField] RectTransform Vidas;
    [SerializeField] TMPro.TMP_Text AvisoVidas;
    float width, widthInicial, height;
    int NumVidas = 3;

    void Awake()
    {
        //Tamaño de la Vida
        widthInicial = Vidas.sizeDelta.x;
        width = Vidas.sizeDelta.x;
        height = Vidas.sizeDelta.y;
        //Añadimos 3 vidas iniciales
        AvisoVidas.gameObject.SetActive(false);
        Vidas.sizeDelta = new Vector2(width * 3, height);

    }

    public void SumarVidas()
    {
        AvisoVidas.gameObject.SetActive(false);
        width = Vidas.sizeDelta.x;
        height = Vidas.sizeDelta.y;
        Vidas.sizeDelta = new Vector2(width + widthInicial, height);
        NumVidas += Vidas.childCount;
        Debug.Log(NumVidas);

    }
    public void RestarVidas()
    {
        NumVidas -= Vidas.childCount;
        if (NumVidas >= 0)
        {
            width = Vidas.sizeDelta.x;
            height = Vidas.sizeDelta.y;

            Vidas.sizeDelta = new Vector2(width - widthInicial, height);

            Debug.Log(NumVidas);
        }
        else
        {
            AvisoVidas.gameObject.SetActive(true);
            AvisoVidas.fontSize = 30;
            AvisoVidas.alignment = TMPro.TextAlignmentOptions.Center;
            AvisoVidas.color = Color.red;
            AvisoVidas.text = "NO TE QUEDAN MAS VIDAS";

        }

    }
}
