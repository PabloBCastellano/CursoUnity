using UnityEngine;

public class Coche : MonoBehaviour
{


    // Update is called once per frame
    [SerializeField] Rigidbody2D chasis;

    void Update()
    {

        //La clase Input sirve para detectar entradas que espera un keyCode 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Debug.Log("Buen Puente");
            //La propiedad AddForce se usa para empujar .El Vector2 es para la fuerza
            chasis.AddForce(new Vector2(-100, 90));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Debug.Log("Buen Puente");
            //La propiedad AddForce se usa para empujar .El Vector2 es para la fuerza
            chasis.AddForce(new Vector2(100, 90));

            //chasis.AddForce(new Vector2(, 90), ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {

            // Debug.Log("Buen Puente");
            //La propiedad AddForce se usa para empujar .El Vector2 es para la fuerza
            chasis.gravityScale = -2.05f;



        }


        //chasis.AddForce(new Vector2(, 90), ForceMode2D.Impulse);
    }







}

