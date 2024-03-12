Console.WriteLine("Digite o operador aritmético desejado: ( + ; - ; * ; /)");
string chosenOperation = Console.ReadLine();

for (float i = 1; i <= 9; i++)
{
    Console.WriteLine($"Tabuada do {i}".PadRight(29, '-'));
    for (float j = 1; j <= 9; j++)
        Console.WriteLine($@"| {i,-5} {chosenOperation, -5} {j,-5} = {string.Format("{0:0.##}",Calculate(i, j)),-5} |");
}
Console.WriteLine("-".PadRight(29, '-'));

float Calculate(float i, float j)
{
    switch (chosenOperation)
    {
        case "+":
            return i + j;
        case "-":
            return i - j;
        case "*":
            return i * j;
        case "/":
            return i / j;
        default:
            Console.WriteLine("Operação inválida!");
            return 0f;
    }            
}