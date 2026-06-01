using UnityEngine;

public class LateUpdateController : MonoBehaviour
{


    //LateUpdate hace la actualizacion al final .Hace uso de el el motor render
    //Se usa para mover las camaras
    void LateUpdate()
    {
        transform.position += Vector3.down * Time.deltaTime;
    }
}
