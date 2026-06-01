using UnityEngine;

/*Mostrar el estado actual del fantasma en un texto.
Cada evento se definirá por la pulsación de una tecla

L Timer Up Leave
E Pacman Eats Power Pill
A Power Pill almost up
U Power Pill timer up
P Eaten by Pac-man
B Arrive at Base
*/
public class Pacman : MonoBehaviour
{

    [SerializeField] TMPro.TMP_Text EstadoFantasma;
    enum Estados
    {
        FantasmaBase, SalidaBase, CambiaPacman, PacmanComePill, PacmanAzul, PacmanBrillante, PierdePoderPill,
        ComidoPorPacMan, VueltaABase
    }
    Estados PosicionFantasma;
    void Awake()
    {
        EstadoFantasma.alignment = TMPro.TextAlignmentOptions.Center;
        EstadoFantasma.fontSize = 30;
        PosicionFantasma = Estados.FantasmaBase;
    }

    public void Update()
    {
        switch (PosicionFantasma)
        {
            case Estados.FantasmaBase:
                if (Input.GetKeyDown(KeyCode.L))
                {

                    EstadoFantasma.text = Estados.SalidaBase.ToString();
                    PosicionFantasma = Estados.SalidaBase;
                }
                break;
            case Estados.SalidaBase:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    EstadoFantasma.text = Estados.PacmanComePill.ToString();
                    PosicionFantasma = Estados.PacmanComePill;
                }

                break;
            case Estados.PacmanComePill:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    EstadoFantasma.text = Estados.PacmanBrillante.ToString();
                    PosicionFantasma = Estados.PacmanBrillante;
                }
                break;
            case Estados.PacmanBrillante:
                if (Input.GetKeyDown(KeyCode.U))
                {
                    EstadoFantasma.text = Estados.PierdePoderPill.ToString();
                    PosicionFantasma = Estados.PierdePoderPill;
                }
                break;
            case Estados.PierdePoderPill:
                if (Input.GetKeyDown(KeyCode.P))
                {
                    EstadoFantasma.text = Estados.ComidoPorPacMan.ToString();
                    PosicionFantasma = Estados.ComidoPorPacMan;
                }
                break;
            case Estados.ComidoPorPacMan:
                if (Input.GetKeyDown(KeyCode.B))
                {
                    EstadoFantasma.text = Estados.VueltaABase.ToString();
                    PosicionFantasma = Estados.VueltaABase;
                }

                break;
            case Estados.VueltaABase:
                PosicionFantasma = Estados.FantasmaBase;
                break;
        }
    }


}
