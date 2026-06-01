using TMPro;
using UnityEngine;

public class Diagrama7 : MonoBehaviour
{
    /*
Crear un InputField en el que se ponga un número entero (establecer content type Integer Number). Ese número entero será el número de vidas iniciales que se
mostrará en una imagen del canvas (tiled) una vez pulsado un botón.
*/

    [SerializeField] RectTransform Vida;
    [SerializeField] TMP_InputField AgregarVida;
    float width, height;
    void Awake()
    {
        //Recuperamos el ancho y el alto inicial
        width = Vida.sizeDelta.x;
        height = Vida.sizeDelta.y;

    }

    public void SumarVida()
    {
        if (int.Parse(AgregarVida.text) < 0)
        {

            AgregarVida.text = "NO Puedes automatarte";
        }
        //Añadimos vidas
        Vida.sizeDelta = new Vector2(width * int.Parse(AgregarVida.text), height);
    }
}
