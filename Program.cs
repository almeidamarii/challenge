using System;
using System.Collections.Generic;

namespace desafiotrello
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Bem-vindo, Walkiria!\n");
      var nome = "";
      int matricula = 0;

      var opcao = "s";

      List<dynamic> alunos = new List<dynamic>();
      while (opcao.ToLower() == "s")
      {
        Console.WriteLine("Digite nome do aluno: \n");
        nome = Console.ReadLine();
        Console.WriteLine("Digite Matricula  do aluno: \n");
        matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite Notas do aluno: \n");
        double[] nota = new double[3];
        double soma = 0;
        double media = 0;
        //nota = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
          Console.WriteLine($"{i + 1}ª nota:");
          nota[i] = Convert.ToDouble(Console.ReadLine());
          soma += nota[i];

        }
        media = soma / nota.Length;

        var resultado = "";
        if (media >= 6)
        {
          resultado = "aprovado";
        }
        else
        {
          resultado = "reprovado";
        }

        alunos.Add(new
        {
          Nome = nome,
          Matricula = matricula,
          Notas = nota,
          Media = media,
          Situacao = resultado
        });




        Console.Clear();
        Console.WriteLine("Deseja cadastrar um novo aluno? S ou N: \n");
        //opcao = Console.ReadLine().ToLower();
        opcao = Console.ReadLine();
      }

      Console.Clear();
      foreach (var aluno in alunos)
      {
        Console.WriteLine($"Nome: {aluno.Nome} - Matricula: {aluno.Matricula}");
        Console.WriteLine($"Notas: ");

        int n = 1;
        foreach (double nota in aluno.Notas)
        {
          Console.WriteLine($"{n} nota: {nota}");
          n += 1;
        }
        Console.WriteLine($"Média: {Math.Round(aluno.Media, 2)} - Situação: {aluno.Situacao}");
      }
    }
  }
}
