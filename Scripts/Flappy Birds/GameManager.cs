
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] TMPro.TMP_Text Resultado;

    [SerializeField] TMPro.TMP_Text Game_Over;
    [SerializeField] TMPro.TMP_Text MensajeFinal;
    [SerializeField] GameObject panel;
    [SerializeField] Bird Bird;
    [SerializeField] Button BotonInicio;

    int Puntos;
    void Awake()
    {
        Assert.IsNotNull(Bird, "EL Pajarito no está en el nido");
        StartGame();


    }

    public void SumarPuntos()
    {
        Puntos += 1;
        Resultado.text = $"Puntuacion: {Puntos.ToString()}";
    }

    public void GameOver()
    {
        Debug.Log("Has Muerto");

        SetupPanel(Constanstes.Perder);
        /*Game_Over.text = $"Puntuacion Final  : {Puntos.ToString()}";
        Bird.setActive(false);
        panel.SetActive(true);*/
    }
    public void Victoria()
    {
        Debug.Log("Has Ganado");
        SetupPanel(Constanstes.Ganar);
        /*panel.SetActive(true);
 Resultado.gameObject.SetActive(false);
 Game_Over.text = $"Puntuacion Final  : {Puntos.ToString()}";*/


    }

    public void StartGame()
    {
        Bird.setActive(true);


        Puntos = 0;
        Resultado.text = $"Puntuacion {Puntos.ToString()}";
        Resultado.gameObject.SetActive(true);
        panel.SetActive(false);
    }

    public void SetupPanel(string Mensaje)
    {
        Resultado.gameObject.SetActive(false);
        if (Mensaje == "Has Ganado")
        {
            MensajeFinal.alignment = TMPro.TextAlignmentOptions.Center;
            MensajeFinal.color = Color.HSVToRGB(0.12f, 0.85f, 0.85f);
        }
        else
        {
            MensajeFinal.color = Color.red;
        }
        MensajeFinal.text = Mensaje;
        Game_Over.text = $"Puntuacion {Puntos.ToString()}";
        panel.SetActive(true);
        Bird.setActive(false);
        BotonInicio.gameObject.SetActive(true);

    }

}
