using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{   
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        public int numeroEsferas = 12;

        void Start()
        {
            GameObject esferaAnterior = null;
            for(int i = 0; i <numeroEsferas;i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                if(esferaAnterior !=null)
                {
                    esfera.transform.localScale = esferaAnterior.transform.localScale * 2f;
                }
                esferaAnterior = esfera;
            }
            
            //❕ Ejercicio08.CrearFiguras(PrimitiveType.Sphere, 12);
        }
    }

}
