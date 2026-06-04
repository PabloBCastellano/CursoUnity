using System;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    // Dado un array de cámaras y al pulsar la tecla C, 
    //      hacer que cambie a la siguiente y vuelta a 
    //      empezar si llegamos a la última. 

    [SerializeField] Camera[] cameras;
    int index;

    void Awake()
    {
        if (cameras.Length == 0)
            throw new Exception("ERROR: faltan cámaras");

        // Apago todas las cámaras
        foreach (var camera in cameras)
        {
            camera.gameObject.SetActive(false);
        }

        //Activo la primera
        index = 0;
        cameras[index].gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Apago la cámara actual
            cameras[index].gameObject.SetActive(false);
            // Actualizo el índice
            index++;
            if (index == cameras.Length)
                index = 0;
            // Encender la nueva
            cameras[index].gameObject.SetActive(true);
        }
    }
}