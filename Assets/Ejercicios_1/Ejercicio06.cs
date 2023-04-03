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
            GameObject sphera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject sphera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            sphera1.transform.position = Vector3.forward * 100f;
            sphera2.transform.position = Vector3.forward * 100f;

            //esfera01.transform.position + new Vector3(100f, 0f, 0f)
            //esfera01.transform.position + Vector3.righ * 100f
        }

        // Update is called once per frame
        void Update()
        {
            // NO HACER new Vector3(esfera01.transform.position.x + 100f, esfera01.transform.position.y, esfera01.transform.position.z)
        }
    }

}
