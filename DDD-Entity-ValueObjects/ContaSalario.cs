namespace DDD_Entity_ValueObjects;

public sealed class ContaSalario : Entity
{
    public Dinheiro Saldo { get; private set; } // --> Value Object

    public ContaSalario(Dinheiro valor)
    {
        if (valor.Valor >= 0)
            Saldo = valor;
        else
            throw new Exception("Saldo da conta negativo");
    }

    public void Deposito(Dinheiro valor)
    {
        Saldo += valor;
    }
    
    public void Saque(Dinheiro valor)
    {
        if (Saldo.Valor >= valor.Valor)
            Saldo -= valor;
        else
            throw new Exception("Saldo insuficiente");
    }
}
