using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class Presentacion
    {

        public static void Inicio()
        {
          
            var cuenta = new CajaDeAhorro("123", 0)
            {
                TasaDeInteres = 0.2M
            };

            var cuenta1 = new CuentaCorriente("44", 12000, 0.1M)
            {
                LimiteDeDescubierto=1200M
            };

            var cuenta2 = new CajaDeAhorro("33", 1011)
            {

                TasaDeInteres = 0.1M
            };

            var cuenta3 = new CuentaCorriente("22", 0, 0.2M)
            {
                LimiteDeDescubierto = 2000M
            };
            try
            {
                cuenta.Depositar(0M);
                cuenta.Retirar(5000M);
                cuenta1.Retirar(13200);
                cuenta1.Depositar(11M);
                cuenta2.Depositar(-1M);
                cuenta3.Depositar(1200M);
                cuenta3.Retirar(1300M);
            }
            catch (Exepciones ex)
            {
                ex.ErrorCritico();
            }

            MostrarCuentas(cuenta);
            MostrarCuentas(cuenta1);
            MostrarCuentas(cuenta2);
            MostrarCuentas(cuenta3);

     
        }

        public static void MostrarCuentas(CuentaBancaria cuenta) {
            Console.WriteLine();
            if (cuenta is CajaDeAhorro)
            {
                
                var aux = new { Tipo = "CajaDeAhorro", Numero = cuenta.Numero, Saldo = cuenta.Saldo };
                Console.WriteLine($"Tipo: {aux.Tipo}");
                Console.WriteLine($"Numero: {aux.Numero}");
                Console.WriteLine($"Saldo: {aux.Saldo}");
            }
            else {
                var aux = new { Tipo = "CuentaCorriente", Numero = cuenta.Numero, Saldo = cuenta.Saldo };

                Console.WriteLine($"Tipo: {aux.Tipo}");
                Console.WriteLine($"Numero: {aux.Numero}");
                Console.WriteLine($"Saldo: {aux.Saldo}");

            }

        }
    }
}   
