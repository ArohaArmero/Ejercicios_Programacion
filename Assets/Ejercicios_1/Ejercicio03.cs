using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un cubo al inicio y duplique su escala
    /// </summary>
    public class Ejercicio03 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);

            transform.localScale = Vector3.one * 2f;

        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}