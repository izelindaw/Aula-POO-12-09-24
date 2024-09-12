public class Contas
{
    public string nome;
    public int CPF;
    public int nmrDaConta;
    public int saldo;

    public Contas(string nomeDaConta, int CPF, int numeroDaConta, int saldo);
    {
        nome = nomeDaConta;
        CPF = CPF;
        nmrDaConta = numeroDaConta;
        saldo = saldo;
    }
}