using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dsw2025Ej8.Domain;


    public class CuentaCorriente : CuentaBancaria{

         public decimal LimiteDeDescubierto { get; init; }
         public decimal Comision { get; set; }  
   
    


        public CuentaCorriente(string numero, decimal saldo, decimal comision) : base(numero, saldo)
        {
           
            Comision = comision;
        }

       
      public override void Depositar(decimal monto) {
        try {
            if (!(EstadoDeCuenta == Estado.Activa))
                throw new Exepciones($"No se puede operar con la cuenta {EstadoDeCuenta}");

            if (monto > 0)
            {
                monto -= monto * Comision;
                Saldo += monto;
            }
            else
            {
                throw new Exepciones("El monto ingresado no es válido para la operación solicitada");
            }
        }catch(Exepciones ex){
            ex.ErrorCritico();
        }
                    
           
      }

      public override void Retirar (decimal monto)
       {
        try
        {
            if (monto <= 0)
            {
                throw new Exepciones("El monto ingresado no es válido para la operación solicitada");
            }
            
            if (!(EstadoDeCuenta == Estado.Activa))
                throw new Exepciones($"No se puede operar con la cuenta {EstadoDeCuenta }");

            if (Saldo > 0)
            {
                if (Saldo - monto >= -LimiteDeDescubierto)
                {
                    Saldo -= monto;
                }

            }
            else{
                EstadoDeCuenta = Estado.Suspendida;
                throw new Exepciones("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
               
            }

            if (Saldo <= 0) { EstadoDeCuenta = Estado.Suspendida; }

        }catch(Exepciones ex) {
            ex.ErrorCritico();
        }
             
                

    }

}
