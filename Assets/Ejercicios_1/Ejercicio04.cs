using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio04 : MonoBehaviour
    {   /// <summary>
        /// Crear un script que genere una esfera al inicio con un Rigidbody añadido
        /// <summary>
        // Start is called before the first frame update
        void Start()
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
