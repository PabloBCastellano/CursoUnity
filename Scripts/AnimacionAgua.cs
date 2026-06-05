using UnityEngine;

public class AnimacionAgua : MonoBehaviour
{
    [SerializeField, Range(0.1f, 3)] float TiempoDestruccion = 0.1f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("He llegado");
            //Con Destroy podemos tambien establecer tambien el tiempop
            Destroy(collision.gameObject, TiempoDestruccion);
        }
    }
}



