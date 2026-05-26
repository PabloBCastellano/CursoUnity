using UnityEngine;


public class ScoreVolumen : MonoBehaviour
{
    //Vamos a configurar  los puntos de cuando no  choca 

    public TMPro.TMP_Text Resultado;
    [SerializeField] GameManager JefeControl;

    void Awake()
    {
        Resultado.fontSize = 30;
        Resultado.alignment = TMPro.TextAlignmentOptions.TopJustified;

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Constanstes.Bird))
        {
            JefeControl.SumarPuntos();
        }


    }



}
