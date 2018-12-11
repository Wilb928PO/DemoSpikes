using System.Collections.Generic;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core.ComparisonStrategy
{
    public class DefaultTestComparer : IComparer<ITMTest>
    {
        public int Compare(ITMTest x, ITMTest y)
        {
            /*
            Escenario:
            Varias URLs con TM instalado[sólo se utilizará una para todas las pruebas paralelizables].
            Varios ordenadores como clientes.
            Hay que hacer varias pruebas.

            Problema: 
            Tenemos que hacer todas las pruebas en el menor tiempo posible.

            Resolución:
            Necesitamos crear una estructura capaz de manejar la lista de pruebas pendientes para ejecutar[estructura de prioridad].
            Cada prueba tiene un peso basado en el tiempo que tarda la prueba en ejecutarse. Las pruebas "más pesadas" siempre van primero.
            Atributos de prueba[El atributo de prueba define qué prueba se envía a qué cliente]:

            Paralelizable
            No paralelizable
            Lectura y escritura HDDD
            No LecturaEscrituraHDD

            Flujo de trabajo:
            Primero sacamos de la estructura las pruebas más pesadas.
            Las pruebas no paralelizables son las primeras[Del más pesado al más ligero][La cantidad de pruebas no paralelizables entregadas depende de cuántas URLs estén disponibles, esta información estará en el archivo app.config].
            Si el cliente informa que la prueba falló, la prueba se agrega de nuevo a la lista antes de sacar la siguiente prueba[cada prueba puede ejecutarse hasta 2 veces].
            Si el cliente informa que ha terminado una prueba no paralelizable, el siguiente retiro será siempre una prueba no paralelizable[la prueba no paralelizable siempre va primero]. 
             */

            //mas duracion primero
            throw new System.NotImplementedException();
        }
    }
}
