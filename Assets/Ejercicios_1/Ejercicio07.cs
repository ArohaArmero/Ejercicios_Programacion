using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio07 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject.CreatePrimitive(PrimitiveType.Sphere);

            gameObject.transform.position = new Vector3(5f, 1f, -2f);
            gameObject.transform.position = Vector3.zero;
            gameObject.transform.position = Vector3.up * 10f;

        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
