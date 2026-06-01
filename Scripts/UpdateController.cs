using UnityEngine;

public class UpdateController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update se actualzia cada segundo .Hace uso de el el motor render
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime;
    }
}
