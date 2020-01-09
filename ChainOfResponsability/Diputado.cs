using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class Diputado : Jerarca
    {
        private Jerarca next;
        // se implementa la interfaz Jerarca 
        public void setNext(Jerarca jerarca)
        {
            this.next= jerarca;
        }

        public Jerarca getNext()
        {
            return this.next;
        }

        /*
         aqui en este metodo se establece la lectura de documento 
         dependiendo la jerarquia el documento llegara a la 
         jerarquia que se haya establecido
         */
        public void VerDocumento(int ClasificacionDocumento)
        {
            if (ClasificacionDocumento ==1)
            {
                Console.WriteLine("Leido por el Diputado");
            }
            else
                this.next.VerDocumento(ClasificacionDocumento);
        }      
    }
}
