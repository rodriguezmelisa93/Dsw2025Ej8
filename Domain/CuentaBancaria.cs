namespace Dsw2025Ej8.Domain;


 public abstract class CuentaBancaria
{
    public string Numero { get; protected set; }
    public decimal Saldo { get; protected set;  }
    public Estado EstadoDeCuenta{ get;  set; } 
    public string[]? Titulares { get; set; } 
    public  CuentaBancaria(string numero, decimal saldo)
    {
        Numero = numero;
        Saldo = saldo;
        EstadoDeCuenta = Estado.Activa; 
    }

    

    public abstract void Depositar(decimal monto);

    public abstract void Retirar(decimal monto);
    


    
}