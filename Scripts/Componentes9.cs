using System;
using UnityEngine;

public class Componentes9 : MonoBehaviour
{
    // Dado un array de GameObjects, activar solo aquellos cuyo
    // spriteRenderer tenga forma de círculo (nombre del Sprite
    // contenga “Circle”)
    [SerializeField] GameObject[] gameObjects;

    void Awake()
    {
        if (gameObjects.Length == 0)
            throw new Exception("ERROR: array vacío");

        foreach (var go in gameObjects)
        {
            if (go == null)
                throw new Exception("ERROR: no exite gameObject");

            var spriteRenderer = go.GetComponent<SpriteRenderer>();
            var tieneRenderer = spriteRenderer != null;

            if (spriteRenderer.sprite == null)
                throw new Exception("ERROR: falta sprite");

            var esCirculo = tieneRenderer && spriteRenderer.sprite.name == "Circle";
            if (esCirculo)
                go.SetActive(true);
            else
                go.SetActive(false);
        }
    }
}
