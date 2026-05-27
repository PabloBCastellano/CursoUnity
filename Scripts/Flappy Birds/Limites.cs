using UnityEngine;

public class Limites : MonoBehaviour
{
    //Vamos a crear los limites.
    //Primera colision al chocar
    [SerializeField] GameManager JefeControl;
    void OnCollisionEnter(Collision collision)
    {
        //Vamos a añadir la muerte al pajaro
        if (collision.gameObject.CompareTag(Constanstes.Bird))
        {
            JefeControl.GameOver();
        }

    }

    //Se activa mientras se esta chocando
    /* void OnCollisionStay(Collision collision)
     {
         Debug.Log("El pajaro está Chocando");
     }

     //Se activa cuando se deja de chocar

     void OnCollisionExit(Collision collision)
     {
         Debug.Log("Ya no ha dejado de chocar");
     }*/



}
