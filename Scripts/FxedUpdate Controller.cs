using UnityEngine;

public class FxedUpdateController : MonoBehaviour
{


    //FixedUpdate . Usa el motor de fisicas para moverse
    void FixedUpdate()
    {
        transform.position += Vector3.down * Time.deltaTime;
    }
}
