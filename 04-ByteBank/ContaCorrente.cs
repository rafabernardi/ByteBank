class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;


    public bool Sacar (double Valor)
    {
        if(this.saldo < Valor)
        {
            return false;
        }
        else
        {
            this.saldo -= Valor;
            return true;
        }
    }

    public void Depositar (double Valor)
    {
        this.saldo += Valor;
    }

}

