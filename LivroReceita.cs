

using System;
using System.Collections.Generic;
using Internal;

class Program
{
    public class Livro
    {
        public Livro() { }

        public string Receita { get; set; }
        public string Categoria { get; set; }

        public Livro(string Receita, string Categoria)
        {
            this.Receita = Receita;
            this.Categoria = Categoria;
        }

        static List<Livro> receitasBolo;
        static List<Livro> receitasTorta;

        static void Main(string[] args)
        {
            receitasBolo = new List<Livro>();
            receitasTorta = new List<Livro>();

            Console.WriteLine("Receita de bolo? [para sim digite 1]");
            int digite = Int32.Parse(Console.ReadLine());

            if (digite == 1)
            {
                receitasBolo.Add(new Livro("brigadeiro", "bolo"));
                receitasBolo.Add(new Livro("morango", "bolo"));
                receitasBolo.Add(new Livro("Laranja", "bolo"));
                receitasBolo.Add(new Livro("Cenoura", "bolo"));

                foreach (Livro l in receitasBolo)
                    Console.WriteLine(l.Categoria + " de " + l.Receita);
            }
            else
            {
                Console.WriteLine("Vamos para a próxima categoria!");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Receita de Torta? [para sim digite 1]");
            int escreva = Int32.Parse(Console.ReadLine());

            if (escreva == 1)
            {
                receitasTorta.Add(new Livro("frango", "Torta"));
                receitasTorta.Add(new Livro("carne", "Torta"));
                receitasTorta.Add(new Livro("morango", "Torta"));
                receitasTorta.Add(new Livro("banana", "Torta"));
                receitasTorta.Add(new Livro("batata", "Torta"));
                receitasTorta.Add(new Livro("doce", "Torta"));

                foreach (Livro t in receitasTorta)
                    Console.WriteLine(t.Categoria + " de " + t.Receita);
            }
            else
            {
                Console.WriteLine("sem mais receitas");
            }
        }
    }
}






