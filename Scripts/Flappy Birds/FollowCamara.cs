using UnityEngine;
using UnityEngine.Assertions;

public class FollowCamara : MonoBehaviour
{
    //En esta parte vamos a codificar que la camara siga al pajaro
    [SerializeField] Transform targetTransform;
    Vector3 diferenciaVector;

    void Awake()
    {
        Assert.IsNotNull(targetTransform, "No hay a nadie a quien seguir");
        //Este vector inicia en el pajaro y termina en la camara
        diferenciaVector = transform.position - targetTransform.position;
    }

    void LateUpdate()
    {
        //Cambiamos la posicion de X solo manteniendo la posicion de Y y Z
        transform.position = new Vector3(
            targetTransform.position.x + diferenciaVector.x,
            transform.position.y,
            transform.position.z
        );

    }
}
