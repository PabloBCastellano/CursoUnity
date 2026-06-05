using System.Collections;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

public class Camara2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public new Camera camera;
    [SerializeField, Range(0.1f, 2f)] float DuracionShake = 0.7f;
    [SerializeField, Range(0.1f, 20f)] float Intensidad = 1.7f;

    void Awake()
    {
        //Busca la camara Principal
        camera = Camera.main;

    }

    //Shake Moverse,sacudirse
    public void ShakeDelEditor()
    {
        StartCoroutine(ShakeCorutine());
    }
    IEnumerator ShakeCorutine()
    {

        //EditorApplication.isPaused = true;
        Vector3 DireccionAleatoria;
        Vector3 InitialPosition = camera.transform.position;
        var tiempo = 0f;
        while (tiempo < DuracionShake)
        {
            //Te da un random sobre la superficie de la esfera de radio 1
            DireccionAleatoria = Random.onUnitSphere;
            camera.transform.position = InitialPosition + DireccionAleatoria * Time.deltaTime * Intensidad;

            tiempo += Time.deltaTime;
            yield return null;
            camera.fieldOfView = 60 + Random.Range(-20f, 17f); //hace que la camara parpadee para desenfocar mas 
        }
        camera.transform.position = InitialPosition;
    }
}
