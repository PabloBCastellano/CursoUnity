using UnityEngine;

public class Componentes2 : MonoBehaviour
{
    // Dado un array de GameObjects, activar solo aquellos cuyo índice es par
    public GameObject[] gameObjects;

    void Awake()
    {
        if (gameObjects.Length == 0)
            throw new System.Exception("ERROR: array vacío");

        for (int index = 0; index < gameObjects.Length; index++)
        {
            bool esPar = index % 2 == 0;
            gameObjects[index].SetActive(esPar);
        }
    }
}
