using System;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        var frases = new List<string>();

        frases.Add("O importante não é vencer todos os dias, mas lutar sempre. Waldemar Valle Martins \n");
        frases.Add("Maior que a tristeza de não haver vencido é a vergonha de não ter lutado! Rui Barbosa\n ");
        frases.Add(" Quem ousou conquistar e saiu pra lutar, chega mais longe! Charlie Brown Jr\n");
        frases.Add(" O medo de perder tira a vontade de ganhar. Mussum\n");
        frases.Add(" Aquele que não tem confiança nos outros, não lhes pode ganhar a confiança. Lao-Tsé\n");
        frases.Add("Escolher o seu tempo é ganhar tempo. Francis Bacon \n ");
        frases.Add("Perder para a razão, sempre é ganhar. Aldo Novak\n ");
        frases.Add(" Arriscamo-nos a perder quando queremos ganhar demais. Jean de La Fontaine\n");
        frases.Add(" Muitos sabem ganhar dinheiro, mas poucos sabem gastá-lo. Henry David Thoreau\n");
        frases.Add("O homem digno ganha para viver; o menos honesto vive para ganhar. Textos Judaicos\n ");
        frases.Add(" Para ganhar aquilo que vale a pena ter, pode ser necessário perder tudo mais. Bernadette Devlin\n");
        frases.Add("O mundo está perdido para aqueles que o querem ganhar. Textos Taoístas\n ");

     foreach (var frase in frases)

        {

         Console.WriteLine(frase);

        }


    }
}

