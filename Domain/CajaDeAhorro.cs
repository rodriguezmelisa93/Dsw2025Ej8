using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{

   public class CajaDeAhorro : CuentaBancaria{

    public decimal TasaDeInteres { get; init; }
  

           public CajaDeAhorro(string numero, decimal saldo ): base(numero,saldo)
          {   
             
          }

 




     public override void Depositar(decimal monto){
            try
            {
                if (monto <= 0)
                {
                    throw new Exepciones("El monto ingresado no es válido para la operación solicitada");
                }

                if (!(EstadoDeCuenta == Estado.Activa))
                throw new Exepciones($"No se puede operar con la cuenta {EstadoDeCuenta} ");

            this.Saldo += monto;
            } catch (Exepciones ex) {
                ex.ErrorCritico();
            }
          

     }
     public override void Retirar(decimal monto){
            try
            {
                if (monto <= 0)
                {
                    throw new Exepciones("El monto ingresado no es válido para la operación solicitada");
                }

                if (!(EstadoDeCuenta == Estado.Activa))
                    throw new Exepciones("No se puede operar con la cuenta {estado} (reemplazar por el estado en el que se encuentra)");
                if (Saldo > 0)
                {
                    Saldo -= monto;
                }
                else
                {
                    EstadoDeCuenta = Estado.Suspendida;
                    throw new Exepciones("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
                   
                }

            }
            catch (Exepciones ex) {
                ex.ErrorCritico();
            }

          
             
        }

        public void AplicarIntereses()
        {
            try
            {

                if (!(EstadoDeCuenta == Estado.Activa))
                    throw new Exepciones($"No se puede operar con la cuenta {EstadoDeCuenta} (reemplazar por el estado en el que se encuentra)");

                Saldo += Saldo * TasaDeInteres;
            }
            catch (Exepciones ex){
                ex.ErrorCritico();
            }
        }
       


    }
}
