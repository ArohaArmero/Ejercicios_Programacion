using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   /// <summary>
    /// Crear un script que genere 30 GameObjects al inicio
    /// </summary>
    public class Ejercicio05 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int tama�oObjetos = 30;
            GameObject[] gameObjects = new GameObject[tama�oObjetos];

            for (int i = 0; i < tama�oObjetos; i++)
            {
                Instanciate(gameObjects);
                //gameObjects[i] = new GameObject();
            }

    }
        
        // Update is called once per frame
        void Update()
        {
           
            

        }
    }

}
