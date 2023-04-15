using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   
    /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio07 : MonoBehaviour
    {
        void Start()
        {
            GameObject sphere01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere01.transform.position = Vector3.zero;

            GameObject sphere02 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere01.transform.position = Vector3.zero *100; //❕ (0, 0, 0) * 100 > (0, 0 ,0)

            GameObject sphere03 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere01.transform.position = Vector3.zero *200; //❕ (0, 0, 0) * 200 > (0, 0 ,0)

            //❕ CrearEsferas();
        }

        //❕
        void CrearEsferas()
        {
            for(int i=0; i<3; i++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = Vector3.right * i * 100f;
            }
        }
    }
}
