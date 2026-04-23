class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }

    public SaldoInsuficienteException(string message) : base(message) { }

    public SaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }

    public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"Exception: Valor do saque {saque} é superior ao saldo {saldo}") { }

}