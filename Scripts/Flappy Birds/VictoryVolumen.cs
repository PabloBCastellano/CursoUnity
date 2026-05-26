using UnityEngine;
using UnityEngine.Assertions;

public class VictoryVolumen : MonoBehaviour
{
    [SerializeField] GameManager JefeControl;
    public void Awake()
    {
        Assert.IsNotNull("No hay gestor");
    }
    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag(Constanstes.Bird))
        {
            JefeControl.Victoria();

        }
    }
}
