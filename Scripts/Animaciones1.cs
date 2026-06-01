using UnityEngine;

public class Animaciones1 : MonoBehaviour
{
    [SerializeField] Animator animacion;

    public void AbrirCofre()
    {
        //Creas la animacion
        animacion.SetBool("Abrir", true);
        animacion.SetBool("Cerrar", false);
    }
    public void CerrarCofre()
    {
        //Creas la animacion
        animacion.SetBool("Abrir", false);
        animacion.SetBool("Cerrar", true);
    }
}


