using UnityEngine;

public class ExecutionOrderController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Debug.Log("Despierto");
    }

    void Onable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void OnDestroy()
    {

        Debug.Log("OnDestroy");
    }

    void OnBecameVisible()
    {
        Debug.Log("OnBecameVisible");
    }

    void OnBecameInvisible()
    {
        Debug.Log("OnBecameInvisible");
    }

}
