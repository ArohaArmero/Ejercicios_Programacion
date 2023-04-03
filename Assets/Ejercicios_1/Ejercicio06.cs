using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   /// <summary>
    /// Crear un script que genere dos esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio06 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject.CreatePrimitive(PrimitiveType.Sphere);

            gameObject.transform.position = Vector3.forward * 100f;
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
