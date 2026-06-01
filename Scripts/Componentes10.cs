using System;
using UnityEngine;

public class Componentes10 : MonoBehaviour
{
    // Dado un array de SpriteRenderers y otro de colores, asignar el
    // color a los que tengan el mismo índice, lanzar excepción si los
    // tamaños de los arrays no coinciden o están vacíos

    [SerializeField] SpriteRenderer[] spriteRenderers;
    [SerializeField] Color[] colors;

    void Awake()
    {
        if (spriteRenderers.Length == 0)
            throw new Exception("ERROR: array vacío");
        if (colors.Length == 0)
            throw new Exception("ERROR: array vacío");
        if (colors.Length != spriteRenderers.Length)
            throw new Exception("ERROR: tamaños distintos");

        for (int index = 0; index < colors.Length; index++)
        {
            spriteRenderers[index].color = colors[index];
        }
    }
}
