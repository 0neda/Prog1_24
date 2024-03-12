using System;

// Trabalhando com variáveis C#

// Strings
// Declarando variável sem inicialização
string? message1 = null;
// Inicializar a string com nulo
string? message2 = null;
// Inicializar string vazia
string message3 = System.String.Empty; // ou "";
// Declarar string com valor implicito
var message4 = "Mensagem aleatória";

Console.WriteLine(message4);

// Concatenando Strings
string concat = (message1 == null ? "" : message1) + " " + message2 + " " + message3 + " " + message4;

Console.WriteLine("\n" + concat);

Console.WriteLine("A temperatura hoje {0:D} é {1} ºC", DateTime.Now, 23);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);

// 040324

string nomeCompleto = "Alex Rafael Oneda";
nomeCompleto = nomeCompleto.Replace("Rafael", "Firmino");
Console.WriteLine(nomeCompleto);

// Comparação de strings

bool isNomeEqual = nomeCompleto == "Alex Rafael Oneda";

bool isNomeEqual2 = string.Equals(nomeCompleto, "Alex Firmino Oneda");

Console.WriteLine($"Primeiro: {isNomeEqual}");
Console.WriteLine($"Segundo: {isNomeEqual2}");

// Tipos numéricos
/*

    sbyte:  Armazena valores entre -128 e 127
    short:  Armazena valores entre -32,768 e 32,767
    int:    Armazena valores entre -2,147,483,648 e 2,147,483,647
    long:   Armazena valores entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807
*/

float myFloat = 10.0f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;

