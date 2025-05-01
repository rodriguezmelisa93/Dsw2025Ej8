using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;


    public class CuentaCorriente : CuentaBancaria{

      private decimal _limiteDeDescubierto;
      private decimal _comision;



    public CuentaCorriente(string numero, decimal saldo, decimal limiteDeDescubierto , decimal comision) : base(numero, saldo)
        {
            _limiteDeDescubierto = limiteDeDescubierto;
            _comision = comision;
        }

        // GyS

    public decimal LimiteDeDescubierto { get; init; }
    public decimal Comision { get; set; }  
   
    

  //   aqui irian los otros metodos q pediria la tarea
      public override void Depositar(decimal monto)
      { 
      }
      public override void Retirar (decimal monto)
       {
 
       }




   }
}
