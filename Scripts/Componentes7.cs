using UnityEngine;
using UnityEngine.UIElements;

public class Componentes7 : MonoBehaviour
{
    /*
    Dados dos GameObjects intercambiar sus posiciones (usar
 Transform y la variable position)*/
    public GameObject[] Objectos;
    public void Awake()
    {
        Vector3 posicionObjeto1, posicionObjeto2;

        for (int i = 0; i < Objectos.Length; i++)
        {
            Debug.Log($"La posicion x del objeto {Objectos[i].name} es {Objectos[i].transform.position.x}" +
            $" la posicion y es {Objectos[i].transform.position.y} y la z es {Objectos[i].transform.position.z}");
            posicionObjeto1(new Vector3());
        }
    }
}
