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
        
        static List<Livro> receitaBolo;
        static List<Livro> receitasSorvete;
        static List<Livro> receitasTorta;

        static void Main(string[] args)
        {
            receitaBolo = new List<Livro>();
            receitasSorvete = new List<Livro>();
            receitasTorta = new List<Livro>();

            Console.WriteLine("Receita de Bolo? [para sim digite 1]");
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
 
           Console.WriteLine("Receita de sorvete? [para sim digite 2]");
           int digite = Int32.Parse(Console.ReadLine());

            if (digite == 1)
            {
                receitasSorvete.Add(new Livro("caseiro", "sorvete"));
                receitasSorvete.Add(new Livro("abacaxi", "sorvete"));
                receitasSorvete.Add(new Livro("banana", "sorvete"));
                receitasSorvete.Add(new Livro("abacate", "sorvete"));
                receitasSorvete.Add(new Livro("coco", "sorvete"));
                receitasSorvete.Add(new Livro("maracujá", "sorvete"));
                receitasSorvete.Add(new Livro("chocolate", "sorvete"));
                receitasSorvete.Add(new Livro("limão", "sorvete"));
                receitasSorvete.Add(new Livro("manga", "sorvete"));
                receitasSorvete.Add(new Livro("leite em pó", "sorvete"));
                receitasSorvete.Add(new Livro("frutas vermehas", "sorvete"));
                receitasSorvete.Add(new Livro("amora sem açucar", "sorvete"));
                receitasSorvete.Add(new Livro("manga com maracujá", "sorvete"));
                receitasSorvete.Add(new Livro("chocolate low carb", "sorvete"));
                receitasSorvete.Add(new Livro("leite de aveia", "sorvete"));
                receitasSorvete.Add(new Livro("sensação fit", "sorvete"));
                receitasSorvete.Add(new Livro("negresco", "sorvete"));
                receitasSorvete.Add(new Livro("tapioca", "sorvete"));
                receitasSorvete.Add(new Livro("banana com pasta de avendoim", "sorvete"));
                receitasSorvete.Add(new Livro("açai fit", "sorvete"));
                receitasSorvete.Add(new Livro("manga", "sorvete"));
                receitasSorvete.Add(new Livro("mascarpone com morango", "sorvete"));
                receitasSorvete.Add(new Livro("alfajor", "sorvete"));
                receitasSorvete.Add(new Livro("queijo com goiabada", "sorvete"));
                receitasSorvete.Add(new Livro("graviola", "sorvete"));
                receitasSorvete.Add(new Livro("chocolate branco com amora", "sorvete"));
                receitasSorvete.Add(new Livro("doce de leite com crumble de nozes", "sorvete"));
               
                foreach (Livro l in receitasSorvete)
                    Console.WriteLine(l.Categoria + " de " + l.Receita);
            }
            else
            {
                Console.WriteLine("Vamos para a próxima categoria!");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Receita de Escondidinho? [para sim digite 3]");
            int escreva = Int32.Parse(Console.ReadLine());

            if (escreva == 1)
            {
                receitasEscondidinho.Add(new Livro("batata", "escondidinho"));"));
                receitasEscondidinho.Add(new Livro("batata com frango", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata com sardinha", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata com carne seca", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata com calabresa", "Torta"));
                receitasEscondidinho.Add(new Livro("batata com atum", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata com strogonoff", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata-doce com bacalhau", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata-doce com chester", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata-doce com carne seca", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca com shimeji", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca com picanha", "escondidinho")
                receitasEscondidinho.Add(new Livro("mandioca com carne de soja", "escondidinho"));
                receitasEscondidinho.Add(new Livro("carne seca", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca com proteína de soja", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca salsa com costelinha e catupiry", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca salsa com calabresa", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca com bacalhau", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca salsa com carne", "escondidinho"));
                receitasEscondidinho.Add(new Livro("mandioca vergano com cogumelos", "escondidinho"));
                receitasEscondidinho.Add(new Livro("camarão", "escondidinho"));
                receitasEscondidinho.Add(new Livro("inhame com kani", "escondidinho"));
                receitasEscondidinho.Add(new Livro("batata e cenoura com frango", "escondidinho"));
                receitasEscondidinho.Add(new Livro("low carb de couve flor", "escondidinho"));
                receitasEscondidinho.Add(new Livro("abóbora com linguiça", "escondidinho"));
                receitasEscondidinho.Add(new Livro("couve-flor coom frango", "escondidinho"));                         
                receitasEscondidinho.Add(new Livro("polenta com calabresa", "escondidinho"));
                receitasEscondidinho.Add(new Livro("abóbora com carne moída", "escondidinho"));
                receitasEscondidinho.Add(new Livro("abóbora com carne seca", "escondidinho"));
                receitasEscondidinho.Add(new Livro("cenoura e queijo com frango", "escondidinho"));
                    
                foreach (Livro l in receitasEscondidinho)  
                    Console.WriteLine(t.Categoria + " de " + t.Receita);
            }
            else
            {
                Console.WriteLine("sem mais receitas");
            }
        }
    }
}






