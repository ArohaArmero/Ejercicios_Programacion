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

            //RECUPERRAR COMPONENTES
            //BoxCollider box = gameObject.GetComponent<BoxCollider>();
            //Rigidbody body = gameObject.GetComponent<Rigidbody>();

            //ENCONTRAR OBJETOS EN LA ESCENA
            //GameObject go1 = GameObject.Find("Nombre");
            //GameObject go2 = GameObject.FindWithTag("Etiqueta");
            //Rididbody body = GameObject.FindObjectOfType<Rigidbody>();
            //BoxCollider[] boxes = GameObject.FindObjectsOfType<BoxCollider>()
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }

}
