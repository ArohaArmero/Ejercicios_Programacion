using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject.CreatePrimitive(PrimitiveType.Sphere);

            gameObject.transform.localScale = new Vector3(2f, 1f, 1f);
            gameObject.transform.localScale = Vector3.one * 2f;

            BoxCollider box = gameObject.GetComponent<BoxCollider>();
            Rigidbody body = gameObject.GetComponent<Rigidbody>();
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
