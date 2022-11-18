namespace DDD_Entity_ValueObjects;

public sealed class Dinheiro : ValueObject<Dinheiro>
{
    public decimal Valor { get; private set; }

	public Dinheiro(decimal valor)
	{
		Valor = valor;
	}

    public static Dinheiro operator +(Dinheiro valor1, Dinheiro valor2)
	{
		Dinheiro soma = new Dinheiro(valor1.Valor + valor2.Valor);
		return soma;
	}

    public static Dinheiro operator -(Dinheiro valor1, Dinheiro valor2)
	{
		if (valor1.Valor < valor2.Valor)
		{
			throw new InvalidOperationException("Operação inválida");
		}
		else
		{
			Dinheiro diferenca = new Dinheiro(valor1.Valor - valor2.Valor);
			return diferenca;
		}
	}

	protected override bool EqualsCore(Dinheiro other)
	{
		return Valor == other.Valor;
	}

	protected override decimal GetHashCodeCore()
	{
		decimal hashCode = Valor.GetHashCode();
		return hashCode;
	}
}
