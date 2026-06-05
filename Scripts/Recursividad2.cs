using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    /*Dado una cadena de texto mostrar cada letra usando recursividad.*/
    string frase = "Lorem ipsum dolor sit amet consectetur adipiscing elit auctor," +
        "pharetra vulputate montes molestie habitant vestibulum platea quis suscipit, fringilla tellus malesuada tincidunt velit ornare litora. " +
        "Mollis at vel scelerisque bibendum turpis eu, vivamus augue integer interdum sociis";
    void Awake()
    {

        RecorrerString(0);
    }

    void RecorrerString(int Inicio)
    {
        if (Inicio == frase.Length)
        {

            return;
        }
        Debug.Log(frase[Inicio]);
        RecorrerString(Inicio + 1);

    }
}
