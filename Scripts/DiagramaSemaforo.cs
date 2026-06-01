using UnityEngine;
using UnityEngine.UI;

public class DiagramaSemaforo : MonoBehaviour
{
    [SerializeField] Button CambiarColor;
    [SerializeField] SpriteRenderer[] Luces;
    enum ColoresSemaforo
    {
        Rojo, Ambar, Verde
    }
    ColoresSemaforo CambiarSemaforo;
    public void Cambiar()
    {
        switch (CambiarSemaforo)
        {
            case ColoresSemaforo.Rojo:
                Luces[0].color = Color.red;
                Luces[2].color = Color.white;
                CambiarSemaforo = ColoresSemaforo.Verde;

                break;
            case ColoresSemaforo.Verde:
                Luces[0].color = Color.white;
                Luces[1].color = Color.green;
                CambiarSemaforo = ColoresSemaforo.Ambar;

                break;
            case ColoresSemaforo.Ambar:
                Luces[2].color = Color.HSVToRGB(0.091f, 1.0f, 1.0f);
                Luces[1].color = Color.white;
                CambiarSemaforo = ColoresSemaforo.Rojo;

                break;


        }
    }
}
