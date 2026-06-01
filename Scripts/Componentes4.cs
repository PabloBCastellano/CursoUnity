
using UnityEngine;

public class Componentes4 : MonoBehaviour
{
    // Dado un GameObject, comprobar si tiene Rigidbody2D, cambiar su gravedad a 10 
    //      y lanzar una excepción cuando no la tenga
    // Dado el GameObject accedemos a su componente Rigidbody2D
    public GameObject go;

    void Awake()
    {
        if (go == null)
            throw new System.Exception("ERROR: falta gameObject");

        var rigidbody2D = go.GetComponent<Rigidbody2D>();

        if (rigidbody2D == null)
            throw new System.Exception("ERROR: Houston falta componente");

        rigidbody2D.gravityScale = 10;
    }
}
