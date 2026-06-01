using UnityEngine;

public class Componentes5 : MonoBehaviour
{
    // Dado un array de GameObject, activar solo los que tengan 
    // componente SpriteRenderer, si está vacío lanzar excepción. 
    // Debemos usar estructura for.
    [SerializeField] private GameObject[] gameObjects;

    void Awake()
    {
        if (gameObjects.Length == 0)
            throw new System.Exception("ERROR: array vacío");

        for (int index = 0; index < gameObjects.Length; index++)
        {
            bool hasRenderer = gameObjects[index].GetComponent<SpriteRenderer>() != null;
            gameObjects[index].SetActive(hasRenderer);
        }
    }
}
