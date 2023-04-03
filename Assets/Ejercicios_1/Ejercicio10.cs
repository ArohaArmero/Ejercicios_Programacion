using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    public class Ejercicio10 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //gameObject.transform.name

            GameObject go1 = GameObject.Find("Nombre");
            GameObject go2 = GameObject.FindWithTag("Etiqueta");
            //Rididbody body = GameObject.FindObjectOfType<Rigidbody>();
            BoxCollider[] boxes = GameObject.FindObjectsOfType<BoxCollider>();
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
