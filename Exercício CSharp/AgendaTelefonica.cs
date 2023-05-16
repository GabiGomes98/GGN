using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

class program
{
    public class Agenda
    {
    }
    public class AgendaTelefonica
    {
        public AgendaTelefonica()
        { }
        public string Nome { get; set; }
        public int Telefone { get; set; }

        public AgendaTelefonica(string nome, int telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }
    }

    static void Main(string[] args)
    {
        List<AgendaTelefonica> contatos = new List<AgendaTelefonica>();

        do
        {
            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite um número: ");
            int telefone = Int32.Parse(Console.ReadLine());

            contatos.Add(new AgendaTelefonica(nome, telefone));

            Console.WriteLine("Adicionar mais um número? [aperte S para continuar ou qualquer outra tecla para sair]");
        } while (Console.ReadLine().ToUpper() == "S");

        Console.WriteLine("Contatos adicionados:");

        foreach (AgendaTelefonica contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone}");
        }
    }
}
