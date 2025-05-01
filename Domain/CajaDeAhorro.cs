using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
   public class CajaDeAhorro : CuentaBancaria{
          private decimal _tasaDeInteres;

         public CajaDeAhorro(string numero, decimal saldo, decimal tasaDeInteres )
             : base(numero,saldo)
          {   
               _tasaDeInteres = tasaDeInteres;
           }

    // G y S 

    public decimal TasaDeInteres { get; init; }
  

     public override void Depositar(decimal monto){
    
     }
     public override void Retirar(decimal monto){
    
     }

     public void AplicarIntereses(){
    
    }

     
    }
}
