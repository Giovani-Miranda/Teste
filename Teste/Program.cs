namespace teste;

public class Produto
{
    public int Id { get; }
    public string Nome { get; }
    public decimal Preco { get; }
    public string Categoria { get; }

    public Produto(int id, string nome, decimal preco, string categoria)
    {
        if (id <= 0 || preco <= 0 || string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(categoria))
            throw new ArgumentException("Dados inválidos para o produto");

        Id = id;
        Nome = nome;
        Preco = preco;
        Categoria = categoria;
    }
}

public class Cliente
{
    public int Id { get; }
    public string Nome { get; }
    public string Email { get; }
    public string Cpf { get; }

    public Cliente(int id, string nome, string email, string cpf)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Cpf = cpf;
    }
}

