using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
<<<<<<< HEAD
   public class CajaDeAhorro : CuentaBancaria{
          private decimal _tasaDeInteres;

         public CajaDeAhorro(string numero, decimal saldo, decimal tasaDeInteres )
             : base(numero,saldo)
          {   
               _tasaDeInteres = tasaDeInteres;
           }

    // G y S 
=======
    internal class CajaDeAhorro : CuentaBancaria{

        private decimal TasaDeInteres { get; set; }
        public CajaDeAhorro(string numero, decimal saldo) : base(numero, saldo)
        {
            

        }
>>>>>>> f250fe2178befd2821e09195d509ec790385a6ce

    public decimal TasaDeInteres { get; init; }
  

<<<<<<< HEAD
     public override void Depositar(decimal monto){
    
     }
     public override void Retirar(decimal monto){
    
     }

     public void AplicarIntereses(){
    
    }

     
=======
        // G y S
        //public decimal GetTasaDeInteres() => _tasaDeInteres;
        // public void SetTasaDeInteres(decimal tasaDeInteres) => _tasaDeInteres = tasaDeInteres;


       public override void Depositar(decimal monto){
      
       }
       public override void Retirar(decimal monto){
      
       }
       public void AplicarIntereses(){
      
       }
       

>>>>>>> f250fe2178befd2821e09195d509ec790385a6ce
    }
}
