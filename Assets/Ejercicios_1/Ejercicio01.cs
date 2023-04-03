using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un GameObject al inicio cuyo nombre sea "Ejercicio01"
    /// </summary>
    public class Ejercicio01 : MonoBehaviour
    {

        private void Start()
        {
            GameObject GO = new GameObject("Ejercicio01");

            Debug.Log("Hola soy: " + GO.name);
        }
        private void Update()
        {
            
            
        }
    } 
}
