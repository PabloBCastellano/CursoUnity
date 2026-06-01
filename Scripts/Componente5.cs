using System;
using Unity.VisualScripting;
using UnityEngine;

public class Componente5 : MonoBehaviour
{

    [SerializeField] private GameObject[] gameObjects;
    void Awake()
    {
        if (gameObjects.Length > 0)
        {
            for (int i = 0; i < gameObjects.Length; i++)

            {
                gameObjects[i].SetActive(false);
                if (gameObjects[i].GetComponent<SpriteRenderer>())
                {
                    gameObjects[i].SetActive(true);
                }
            }
        }
        else
        {
            throw new Exception("No tengo elementos en mi lista");
        }
    }
}
