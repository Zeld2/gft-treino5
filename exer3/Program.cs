// See https://aka.ms/new-console-template for more information
using exer3;
using static System.Console;

List<Morador> moradores = new List<Morador>();

var morador1 = new Morador("123456789", 120, false);
moradores.Add(morador1);
var morador2 = new Morador("1934832433", 123, false);
moradores.Add(morador2);
var morador3 = new Morador("645646564", 126, true);
moradores.Add(morador3);
var morador4 = new Morador("21231231", 129, true);
moradores.Add(morador4);
var morador5 = new Morador("1234232139", 132, false);
moradores.Add(morador5);
var morador6 = new Morador("123442142", 135, false);
moradores.Add(morador6);
var morador7 = new Morador("123213", 138, false);
moradores.Add(morador7);
var morador8 = new Morador("5466789", 141, true);
moradores.Add(morador8);
var morador9 = new Morador("4214589", 144, false);
moradores.Add(morador9);



var sair = false;

do
{
    var i = 1;
    foreach (var item in moradores)
    {
        System.Console.WriteLine($"{i}. " + item.ToString());
        i++;
    }
    i = 1;

    Console.WriteLine("");
    Console.WriteLine("Qual casa você deseja verificar se tem cachorro e fazer a entrega? Digite 0 para sair");
    var opcaoUsuario = Int32.Parse(Console.ReadLine());
    if (opcaoUsuario == 0)
    {
        System.Console.WriteLine("Saindo do programa");
        sair = true;
    }
    else
    {
        try
        {
            var moradorTeste = moradores[opcaoUsuario - 1];
            System.Console.WriteLine("Casa tem cachorro? " + moradorTeste.TemCachorro());
            if (!moradorTeste.Cachorro)
            {
                moradorTeste.EntregarCorrespondencia();
                System.Console.WriteLine("Coresspondência entregue.");
                WriteLine("");
                Write("Aperte qualquer tecla para continuar.");
                WriteLine("");
                ReadKey();
            }
            else
            {
                System.Console.WriteLine("Correspondência não entregue.");
                WriteLine("");
                Write("Aperte qualquer tecla para continuar.");
                WriteLine("");
                ReadKey();
            }
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex);
        }
    }

} while (!sair);

var contador = 0;

foreach (var item in moradores)
{
    if (item.ParOuImpar()) contador += item.Correspondencias;
}

System.Console.WriteLine($"Correspondências entregues para casas com números ímpares: {contador}");



