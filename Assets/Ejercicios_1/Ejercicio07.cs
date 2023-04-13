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
            GameObject sphera01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphera01.transform.position = Vector3.zero;

            GameObject sphera02 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphera01.transform.position = Vector3.zero *100;

            GameObject sphera03 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphera01.transform.position = Vector3.zero *200;


        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
