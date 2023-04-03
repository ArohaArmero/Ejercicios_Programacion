using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   /// <summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    /// </summary>
    public class Ejercicio08 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);

            //gameObject.transform.localScale = Vector3.one * 2f++;
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
