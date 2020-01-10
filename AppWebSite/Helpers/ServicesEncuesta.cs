using AppWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebSite.Helpers
{
    public class ServicesEncuesta
    {
        /// <summary>
        /// Funcion para poder validar la si el registro puede guardarse en la base de datos.
        /// </summary>
        /// <param name="encEncontrada"></param>
        /// <param name="encRegistro"></param>
        /// <returns></returns>
        public static bool puedeRegistrar(Encuesta encEncontrada, Encuesta encRegistro)
        {
            //Validar si la encuesta encontrada existe
            if( encEncontrada == null)
            {
                // Si no existe entonces si se puede grabar
                return true;
            }
            else
            {
                if(encRegistro.Enemail.CompareTo(encEncontrada.Enemail)==0)
                {
                    if(encRegistro.Enfecha == encEncontrada.Enfecha)
                    {
                        //Si la fecha es diferente, puede registrar
                        return false;
                    }
                    else
                    {
                        // si la fecha es la misma, no puede agregar
                        return true;
                    }
                }
                else
                {
                    //Retorna verdadero por que la encuesta es registrada con diferente email
                    return true;
                }
            }
        }

    }
}
