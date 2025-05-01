namespace Dsw2025Ej8.Domain;

 abstract class CuentaBancaria{

    private string _numero;
    private decimal _saldo;
    public Estado EstadoDeCuenta { get; set; }
  
    public string[] Titulares { get; set; }
  



     public CuentaBancaria(string numero, decimal saldo){

       _numero = numero;
       _saldo = saldo;

     }
    public abstract void Depositar(decimal monto);
    
    
    public abstract void Retirar(decimal monto);



   
    /*
    public void Depositar(decimal monto)
    {
        if (_tipo == TipoCuenta.CajaDeAhorro)
        {
            _saldo += monto;
        }
        else if (_tipo == TipoCuenta.CuentaCorriente)
        {
            monto -= monto * _comision;
            _saldo += monto;
        }
    }

    public void Retirar(decimal monto)
    {
        if (_tipo == TipoCuenta.CajaDeAhorro)
        {
            _saldo -= monto;
        }
        else if (_tipo == TipoCuenta.CuentaCorriente)
        {
            if (_saldo - monto >= -_limiteDeDescubierto)
            {
                _saldo -= monto;
            }
            if (_saldo < 0)
            {
                _estado = Estado.Suspendida;
            }
        }
    }

    public void AplicarInteres()
    {
        if (_tipo == TipoCuenta.CajaDeAhorro)
        {
            _saldo += _saldo * _tasaDeInteres;
        }
    }
    */
}
