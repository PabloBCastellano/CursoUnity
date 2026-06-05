using UnityEngine;

public class Animaciones1 : MonoBehaviour
{
    [SerializeField] Animator animacion;

    public void AbrirCofre()
    {
        //Creas la animacion
        animacion.SetBool("Abrir", true);
        animacion.SetBool("Cerrar", false);
        Debug.Log("Abriendo");
    }
    public void CerrarCofre()
    {
        //Creas la animacion
        animacion.SetBool("Abrir", false);
        animacion.SetBool("Cerrar", true);
        Debug.Log("Cerrando");
    }
}


