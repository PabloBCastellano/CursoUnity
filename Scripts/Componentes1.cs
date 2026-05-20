using UnityEngine;
using System;
public class Componentes1 : MonoBehaviour
{
    public GameObject[] objetos;

    void Awake()
    {
        if (objetos.Length == 0)
        {
            throw new Exception("No he encontrado ningun objeto");
        }
        else
        {
            foreach (var compomentes in objetos)
            {
                //la propiedad SetActivate te enciende o te apaga los objectos
                compomentes.SetActive(false);
                objetos[0].SetActive(true);
                objetos[(objetos.Length - 1)].SetActive(true);
            }
        }
    }
}
