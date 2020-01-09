using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class Gobierno : Jerarca
    {
        private Jerarca next;
        // se implementa la interfaz Jerarca
        public void setNext(Jerarca jerarca)
        {
            this.next = jerarca;
        }

        public Jerarca getNext()
        {
            return this.next;
        }
            
        /*
         una vez que se tienen las clases se crea la cadena, se define
         el primero en la sucesion, y los sucesores de cada uno de los miembros
         de la cadena
        */
        public void VerDocumento(int ClasificacionDocumento)
        {
            Diputado diputado = new Diputado();
            Ministro ministro = new Ministro();
            Presidente presidente = new Presidente();

        
            this.next = diputado;
            diputado.setNext(ministro);
            this.next = ministro; 
            ministro.setNext(diputado);
            diputado.setNext(presidente);
            //se inicia la cadena
            this.next.VerDocumento(ClasificacionDocumento);
        }
    }
}
