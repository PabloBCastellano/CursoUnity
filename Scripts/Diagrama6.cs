using Unity.VisualScripting;
using UnityEngine;

public class Diagrama6 : MonoBehaviour
{
    enum EstadosVida
    {
        Vivo, Vida0, Vida1, Vida2, Vida3, Muerto, Fantasma
    }
    [SerializeField] TMPro.TMP_Text EstadoPersona;
    int NumVidas = 1;
    EstadosVida EstasVivo;
    void Awake()
    {
        EstadoPersona.fontSize = 24;
    }

    // Update is called once per frame
    public void QuitarVida()
    {
        switch (EstasVivo)
        {
            case EstadosVida.Vivo:
                EstadoPersona.text = NumVidas.ToString();
                if (NumVidas >= 0)
                {
                    NumVidas--;
                    EstadoPersona.text = NumVidas.ToString();
                    EstasVivo = EstadosVida.Muerto;
                }



                break;

            case EstadosVida.Muerto:
                EstadoPersona.text = NumVidas.ToString();
                EstasVivo = EstadosVida.Fantasma;
                break;
            case EstadosVida.Fantasma:
                EstasVivo = EstadosVida.Fantasma;
                EstadoPersona.text = "Estas Muerto,no te has enterado?";
                break;

        }
    }
}
