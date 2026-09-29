using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDeDiseño.PSingleton
{
    public class Singleton
    {
        public static Singleton instance;

        private Singleton()
        {

        }

        public static Singleton objetoSingleton () {
            if (instance == null)
            {
                instance = new Singleton();
            }
            else {
                Console.WriteLine("El objeto ya existe");            
            }


            return instance;
        }

    }
}

#region administradores de acceso
/*
 public 
 privado 
 protected
 */
#endregion
#region constructor 
/* 
 * crear un nuevo objeto indicar sus propiedades
   se debe llamar como el nombre exacto de la clase
   public sino se aplica el patro singleton

 public Singleton()
        {

        }
*/
#endregion

#region Metodos en programacion
/*
 funciones anonimas  ()=> 
 Funciones ciclicas 
 funciones abstractas -> son funciones que solo tiene el nombre 
 funciones staticas  -> no se necesita una instancia para poder 
 ejecutarlas
 funiones virtuales que son las que vamos a poder sobreescribir 
fucnion clasicas. modificaror de acceso dato nombre () {}
 */
#endregion
#region tipos de datos apartir de una clase
/*   
propiedades 
metodos 
argumentos de su constructor

cuando crean una clase esta definiendo un tipo de datos 
que pueden llamarlo en las funciones como una instacia para
Aprovechar la funcion personalizada del tipo de dato.

Clase  auto 
LAs propiedades 

motoro  auto   motorauto(){ logica}
*/
#endregion

#region espacio de memoria
/*
 si  este espacio de memoria es igual a 
 x78 = objeto
 pagianciones con las propiedades
 */
#endregion
 
#region 
/* duncion statica y una propiedad estica*/ 
/*las funciones staticas casi siempre las 
utilizaran con las variables staticas*/
#endregion