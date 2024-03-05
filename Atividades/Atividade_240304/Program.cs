Console.WriteLine(@$"Selecione o operador aritmético
* : Multiplicação
/ : Divisão
- : Subtração
+ : Adição
[Qual sua seleção?]");

string? userSelection = Console.ReadLine();

Console.WriteLine("Digite o primeiro número:");
float firstNumber = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
float secondNumber = float.Parse(Console.ReadLine());

float finalResult;

switch(userSelection)
{
    case "*":
        finalResult = firstNumber * secondNumber;
        Console.WriteLine($"A multiplicação de {firstNumber} por {secondNumber} é: {finalResult}");
        break;
    case "/":
        finalResult = firstNumber / secondNumber;
        Console.WriteLine($"A divisão de {firstNumber} por {secondNumber} é: {finalResult}");
        break;
    case "-":
        finalResult = firstNumber - secondNumber;
        Console.WriteLine($"A subtração de {firstNumber} por {secondNumber} é: {finalResult}");
        break;
    case "+":
        finalResult = firstNumber + secondNumber;
        Console.WriteLine($"A adição de {firstNumber} por {secondNumber} é: {finalResult}");
        break;
}