using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael_Cartsys.src.Models
{
  internal class Person
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public string Cidade { get; set; }
    public string Telefone { get; set; }
    public int Idade { get; set; }
    public char Sexo { get; set; }

    public Person(int id, string nome, string email, string cpf, string rua, string bairro, string numero,
      string cidade, string telefone, int idade, char sexo)
    {
      this.Id = id;
      this.Nome = nome;
      this.Email = email;
      this.Cpf = cpf;
      this.Rua = rua;
      this.Bairro = bairro;
      this.Numero = numero;
      this.Cidade = cidade;
      this.Telefone = telefone;
      this.Idade = idade;
      this.Sexo = sexo;
    }
  }
}
