using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace _01_HelloWorld;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine($"Usuário {nome} seja bem-vindo!");

        Console.WriteLine("Digite seu sobrenome");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome é {nome} {sobrenome}");
        Console.WriteLine(); 


        double numero1 = 2;
        double numero2 = 3;

        var resultado = numero1 + numero2;
        Console.WriteLine($"O resultado de 2 + 3 é: {resultado}");

        var subtracao = numero1 - numero2;
        Console.WriteLine($"A subtracao de 2 - 3 é: {subtracao}");

        var multiplicacao = numero1 * numero2;
        Console.WriteLine($"A multiplicacao de 2 * 3 é: {multiplicacao}");

        var divisao = numero1 / numero2;
        if (numero2 == 0)
        {
            Console.WriteLine("Digite um numero positivo");
        }
        else
        {
            Console.WriteLine($"A divisao de 2 / 3 é: {divisao}");
        }

        var media = numero1 % numero2;
        Console.WriteLine($"A média de 2 e 3 é: {media}");
        Console.WriteLine();

        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();

        var suaPalavraTem = palavra.Length;
        Console.WriteLine($"Sua palavra tem {suaPalavraTem} caracteres");
        Console.WriteLine();

        Console.WriteLine("Digite a placa do veículo");
        var placa = Console.ReadLine();

        string padrao = @"^[a-z/A-Z]{3}\d{4}$";


        if (Regex.IsMatch(placa, padrao))
        {
            Console.WriteLine("Sua placa é valida!");
        }

        else
        {
            Console.WriteLine("Sua placa é invalida");
        }
        Console.WriteLine();

        DateTime hoje = DateTime.Now;
        string diaEmTexto = hoje.ToString("dddd/MMMM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine($"Data: {diaEmTexto}");


        DateOnly dia = new DateOnly(2023, 12, 1);
        Console.WriteLine($"Hoje é dia: {dia}");

        string hora = hoje.ToString("HH");
        Console.WriteLine($"A hora atual é: {hora}");

        string mes = hoje.ToString("MMMM");
        Console.WriteLine($"Estamos no mes: {mes}");
    }
}

