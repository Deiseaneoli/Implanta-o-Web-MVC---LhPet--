namespace LhPet.Models;

public class ClientePet
{
public int Id {get;set;}
public string? Nome { get; set; }
public string? Cpf { get; set;}
public string? Email { get; set;}
public string? Paciente { get; set;}

public ClientePet(int id, string nome, string cpf,string email, string paciente)
{
    this.Id = id;
    this.Nome = nome;
    this.Cpf = Cpf;
    this.Email = email;
    this.Paciente = paciente;
}
}