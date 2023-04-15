using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   
    /// <summary>
    /// Crear un script que genere dos esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio06 : MonoBehaviour
    {
        void Start()
        {
            GameObject sphera01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphera01.transform.position = Vector3.zero;
            //esfera01.transform.position = new Vector3(0f, 0f, 0f)

            GameObject sphera02 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphera02.transform.position = Vector3.forward * 100f;
            //esfera02.transform.position = new Vector3(0f, 0f, 100f)
        }
    }
}
