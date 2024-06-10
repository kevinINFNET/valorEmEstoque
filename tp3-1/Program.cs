public class Produto
{
    private string nome;
    private decimal preco;
    private int quantidade;

    public Produto(string nome, decimal preco, int quantidade)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
    }

    public string Nome
    {
        get { return nome; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nome = value;
            }
            else
            {
                throw new ArgumentException("Nome não pode ser vazio.");
            }
        }
    }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
            {
                preco = value;
            }
            else
            {
                throw new ArgumentException("Preço não pode ser negativo.");
            }
        }
    }

    public int Quantidade
    {
        get { return quantidade; }
        set
        {
            if (value >= 0)
            {
                quantidade = value;
            }
            else
            {
                throw new ArgumentException("Quantidade não pode ser negativa.");
            }
        }
    }

    public decimal ValorEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Computador gamer ", 4000.00m, 10);
        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Preço: {produto.Preco:C}");
        Console.WriteLine($"Quantidade: {produto.Quantidade}");
        Console.WriteLine($"Valor em Estoque: {produto.ValorEmEstoque():C}");
    }
}
