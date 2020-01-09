using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    interface Jerarca
    {

        // se define la interfaz con los metodos que requiera el programa

        public void setNext (Jerarca jerarca);
        //asigna el siguiente jerarca en la cadena de responsabilidad

        public Jerarca getNext ();
        //retorna el siguiente jerarca en la cadena de r.

        public void VerDocumento(int ClasificacionDocumento);
        // este metodo permite ver el documentodependiendo
        //del acceso que tenga el jerarca


        // se crean las clases y se implementa la interfaz  (Clase Diputado,Clase Ministro,Clase Presidente)


        //Una vez que se tienen las clases que van a formar la cadena, se define el primero en la sucesión,
        //y los sucesores de cada uno de los miembros de la cadena. (clase Gobierno)

    }
}
