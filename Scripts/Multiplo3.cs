using Unity.VisualScripting;
using UnityEngine;

public class Multiplo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Rigidbody2D[] ObjectosGravedad;
    void Awake()
    {

        for (int i = 0; i < ObjectosGravedad.Length; i++)
        {
            ObjectosGravedad[i].gameObject.SetActive(false);
            if (i % 3 == 0)
            {
                ObjectosGravedad[i].gameObject.SetActive(true);
            }
            else
            {
                ObjectosGravedad[i].gameObject.SetActive(false);
            }

        }
    }
}

