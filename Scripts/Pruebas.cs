using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class Pruebas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sirve para hacer los los es el equivalente a console.WritleLine
        Debug.Log("Hola Mundo");

        string Palabra="Pablo";
        
        bool Color=false;
        char letra='j';
       
        if (Color == true)
        {
            Debug.Log("Mi color es verde");
            
        }
        else
        {
            Debug.Log("No tengo "+letra+"olor");
        }
        Debug.Log("me llamo "+ Palabra);
    }

}
  
