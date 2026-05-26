using System;
using UnityEngine;
using UnityEngine.Assertions;

public class Bird : MonoBehaviour
{
    //Instanciamos el right body para las fisicas
    new Rigidbody rigidbody;
    [SerializeField, Range(0f, 15F), Tooltip("Velocidad de vuelo")] float velocidadVuelo = 0.37f;
    [SerializeField, Range(0f, 15F), Tooltip("Velocidad horizontal")] float velocidadx = 3.7f;
    [SerializeField, Range(0.1f, 10f)] float MultiplicadorRotacion = 3f;
    Vector3 PosicionInicial;
    bool EstaVolando;

    //Quiaternion se usa para la rotacion
    Quaternion RotacionInicial;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Assert.IsNotNull(rigidbody, "Rightbody NO encontrado");
        PosicionInicial = transform.position;
        RotacionInicial = transform.rotation;



    }


    void Update()
    {
        UpdateInput();
        UpdateRotacion();
    }

    public void UpdateInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) & !EstaVolando)
            EstaVolando = true;
    }
    void UpdateRotacion()
    {
        //Vamos a trabajar con quaterniones para realizar la rotacion
        transform.rotation = Quaternion.Euler(0, 0, rigidbody.linearVelocity.y * MultiplicadorRotacion);
    }
    public void FixedUpdate()
    {

        rigidbody.linearVelocity = new Vector3(velocidadx, rigidbody.linearVelocity.y, rigidbody.linearVelocity.z);
        // rigidbody.AddForce(Vector3.right * velocidadVuelo, ForceMode.Acceleration);
        if (EstaVolando)
        {
            EstaVolando = false;
            //Añadimos la fuerza Con Vector3.up hacemos que suba
            rigidbody.AddForce(Vector3.up * velocidadx, ForceMode.VelocityChange);
            Debug.Log("El pajaro esta volando");
        }
    }

    public void setActive(bool NuevoValor)
    {
        if (NuevoValor == true)
        {
            transform.position = PosicionInicial;
            transform.rotation = RotacionInicial;
            //enabled viene con Monobehaivour
            enabled = true;
        }
        else
        {
            enabled = false;
        }
    }
}
