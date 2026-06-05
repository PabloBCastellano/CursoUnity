using UnityEngine;
using UnityEngine.UI;

public class Fuente : MonoBehaviour
{
    [SerializeField] Button SinAgua, AguaAzul, AguaRoja;
    [SerializeField] Animator animacionFuente;

    void Awake()
    {
        //Evitas que el boton sea interactivo
        SinAgua.interactable = false;
    }

    public void NoAgua()
    {
        animacionFuente.SetTrigger("SinAgua");
        AguaAzul.interactable = true;
        AguaRoja.interactable = true;
        SinAgua.interactable = false;
    }
    public void Azul()
    {
        animacionFuente.SetTrigger("AguaAzul");
        AguaAzul.interactable = false;
        AguaRoja.interactable = true;
        SinAgua.interactable = true;
    }
    public void Rojal()
    {
        animacionFuente.SetTrigger("AguaRoja");
        AguaAzul.interactable = true;
        AguaRoja.interactable = false;
        SinAgua.interactable = true;
    }
}
