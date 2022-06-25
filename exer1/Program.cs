// See https://aka.ms/new-console-template for more information
using exer1;

Console.WriteLine("Olá, criando o registro de alguns colaboradores.");


var colaboradorSemEnsino = new Colaborador("Cleber","12345");

var colaboradorComEnsino = new ColaboradorEnsino("Joao", "23456", "João E.M");

var colaboradorComFaculdade = new ColaboradorSuperior("Matheus", "34567", "Maristela E.E" ,"UNESP");

System.Console.WriteLine("");
System.Console.WriteLine(colaboradorSemEnsino.ToString());
System.Console.WriteLine("");
System.Console.WriteLine(colaboradorComEnsino.ToString());
System.Console.WriteLine("");
System.Console.WriteLine(colaboradorComFaculdade.ToString());