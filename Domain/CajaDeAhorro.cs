using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CajaDeAhorro : CuentaBancaria{

        private decimal TasaDeInteres { get; set; }
        public CajaDeAhorro(string numero, decimal saldo) : base(numero, saldo)
        {
            

        }


        // G y S
        //public decimal GetTasaDeInteres() => _tasaDeInteres;
        // public void SetTasaDeInteres(decimal tasaDeInteres) => _tasaDeInteres = tasaDeInteres;


       public override void Depositar(decimal monto){
      
       }
       public override void Retirar(decimal monto){
      
       }
       public void AplicarIntereses(){
      
       }
       

    }
}
