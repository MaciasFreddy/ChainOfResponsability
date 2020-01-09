using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               aqui se imprime quien ha leido 
               porque depende de el emisor a 
               quien haya enviado y con eso el receptor 
               es el que leera el documento
               En este caso los lee todos porque 
               cuando se le envia al presidente lo puede leer el diputado y el ministro.
               CADENA DE RESPONSABILIDADES
            */

            /*
             Clasificado → Diputado     (1)
             Secreto → Ministro         (2)
             Muy Secreto → Presidente   (3)

            */
            Gobierno gobierno = new Gobierno();
            gobierno.VerDocumento(1);
            gobierno.VerDocumento(2);
            gobierno.VerDocumento(3);
        }
    }
}
