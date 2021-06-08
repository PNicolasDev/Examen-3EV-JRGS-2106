using System.Collections.Generic;

namespace Examen3EvNamespace
{
    /// <summary>
    /// Clase diseñada para el cálculo de un conjunto de notas.
    /// </summary>
    public class EstadisticasNotas  
    {
        //PNICOLAS 1CFSY 2021
        /// <summary>
        /// Contiene la cantidad de suspensos.
        /// </summary>
        public int suspensos;
        /// <summary>
        /// Contiene la cantidad de aprobados.
        /// </summary>
        public int aprobados;
        /// <summary>
        /// Contiene la cantidad de notables.
        /// </summary>
        public int notables;
        /// <summary>
        /// Contiene la cantidad de sobresalientes.
        /// </summary>
        public int sobresalientes;

        /// <summary>
        /// La nota media del conjunto de notas aportado.
        /// </summary>
        public double notaMedia;

        /// <summary>
        /// Constructor vacío de la clase. Inicializa a 0 las variables.
        /// </summary>
        public EstadisticasNotas()
        {
            suspensos = aprobados = notables = sobresalientes = 0;  // inicializamos las variables
            notaMedia = 0.0;
        }

        /// <summary>
        /// Constructor que a partir de un array, calcula las estadísticas al crear el objeto.
        /// </summary>
        /// <param name="listaNotas">La lista con las notas aportadas de las que se quiere hacer el cálculo.</param>
        public EstadisticasNotas(List<int> listaNotas)//PNICOLAS1CFSY
        {
            notaMedia = 0.0;
            //PNICOLAS 1CFSY2021
            CalcularNotaMedia(listaNotas);
        }
        //PNICOLAS 1CFSY
        /// <summary>
        /// Calcula la nota media de un conjunto de notas aportadas.
        /// </summary>
        /// <param name="listaNotas">La lista con las notas aportadas de las que se quiere hacer el cálculo.</param>
        public void CalcularNotaMedia(List<int> listaNotas)
        {
            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5)
                {
                    suspensos++;
                }
                else if (listaNotas[i] >= 5 && listaNotas[i] < 7)
                {
                    aprobados++;
                }
                else if (listaNotas[i] >= 7 && listaNotas[i] < 9)
                {
                    notables++;
                }
                else if (listaNotas[i] >= 9)
                {
                    sobresalientes++;
                }

                notaMedia = notaMedia + listaNotas[i];
            }
            notaMedia = notaMedia / listaNotas.Count;
        }

        // PNICOLAS 1CFSY
        /// <summary>
        /// Calcula las estadísticas para un conjunto de notas.
        /// </summary>
        /// <param name="listaNotas">La lista con las notas aportadas de las que se quiere hacer el cálculo.</param>
        /// <remarks>Si se introduce un conjunto vacío o con notas desbordadas devolverá una exception.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">Con la cadena "Las lista no puede ser vacía." en caso de que pasemos una lista vacía</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Con la cadena "Las notas no pueden ser menores que cero ni mayores que 10" si metemos notas mayores que 10 o menores que 0</exception>
        /// <returns>Un double con la nota media del conjunto.</returns>
        public double CalcularEstadisticas(List<int> listaNotas) //PNICOLAS1CFSY2021
        {
            notaMedia = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            //PNICOLAS 1CFSY
            if (listaNotas.Count <= 0)
            {
                throw new System.ArgumentOutOfRangeException("Las lista no puede ser vacía.");
            }
            //PNICOLAS 1CFSY
            for (int i = 0; i < listaNotas.Count; i++) //PNICOLAS1CFSY2021
                if (listaNotas[i] < 0 || listaNotas[i] > 10)
                {
                    throw new System.ArgumentOutOfRangeException("Las notas no pueden ser menores que cero ni mayores que 10");
                }

            //PNICOLAS 1CFSY
            CalcularNotaMedia(listaNotas);

            return notaMedia;
        }
    }
}
