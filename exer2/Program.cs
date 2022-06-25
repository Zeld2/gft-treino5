using exer2;
using static System.Console;
using static exer2.CalculoIdade;


var sair = false;

do
{
    WriteLine("");
    WriteLine("Menu de opções");
    WriteLine("");

    WriteLine("1. Idade");
    WriteLine("");

    WriteLine("2. IMC");
    WriteLine("");

    WriteLine("3. Sair");
    WriteLine("");

    WriteLine("Digite a opção desejada");
    WriteLine("");


    var opcaoUsuario = Int32.Parse(ReadLine());

    switch (opcaoUsuario)
    {
        case 1:
            WriteLine("Qual ano você nasceu?");
            var anoNascimento = Int32.Parse(ReadLine());
            var idade = Idade(anoNascimento);
            WriteLine("");
            WriteLine($"Até o final do ano, você terá {idade} anos.");
            WriteLine("");
            Write("Aperte qualquer tecla para continuar.");
            WriteLine("");
            ReadKey();
            break;
        case 2:
            WriteLine("Qual sua altura? (Metros)");
            var altura = Double.Parse(ReadLine());
            WriteLine("Qual seu peso? (Kg)");
            var peso = Double.Parse(ReadLine());
            var pessoa1 = new PessoaIMC(altura, peso);
            var imc = pessoa1.CalculoImc();
            WriteLine("");
            WriteLine($"Seu índice de massa corporal é de: {imc}");
            WriteLine("");
            Write("Aperte qualquer tecla para continuar.");
            WriteLine("");
            ReadKey();
            break;
        case 3:
            WriteLine("Saindo do programa.");
            sair = true;
            break;
        default:
            WriteLine("Opção inválida. Tente novamente");
            WriteLine("");
            Write("Aperte qualquer tecla para continuar.");
            WriteLine("");
            ReadKey();
            break;
    }
} while (!sair);






