using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CuentaCorriente : CuentaBancaria
    {

        private decimal LimiteDeDescubierto { get; set; }
        private decimal Comision { get; set; }
        public CuentaCorriente(string numero, decimal saldo) : base(numero, saldo)
        {
        }

      


 
       
        //   aqui irian los otros metodos q pediria la tarea
        public override void Depositar(decimal monto)
        {
        }
        public override void Retirar(decimal monto)
        {


        }
    }
}
