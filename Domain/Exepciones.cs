using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class Exepciones : Exception
    {

        public Exepciones(string mensaje) : base(mensaje) {
           
            Console.WriteLine($"Excepción: {Message}");
        }

        public void ErrorCritico()
        {
           
        }


    }
}
