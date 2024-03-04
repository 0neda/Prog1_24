string nomeUsuario, eMailUsuario, generoUsuario, cepUsuario, ruaUsuario, numeroUsuario, bairroUsuario, cidadeUsuario, ufUsuario, paisUsuario, dataNascimento = string.Empty;
Console.WriteLine(@"Seja bem vindo ao sistema de ficha cadastral.
        Para iniciar, digite seu nome:
    ");
nomeUsuario = Console.ReadLine(); /* Ler Linha */

Console.WriteLine("Digite seu e-Mail:");
eMailUsuario = Console.ReadLine();

Console.WriteLine("Digite sua data de nascimento (dd/mm/yy)");
dataNascimento = Console.ReadLine();

Console.WriteLine("Digite seu gênero:");
generoUsuario = Console.ReadLine();

Console.WriteLine("Digite seu CEP:");
cepUsuario = Console.ReadLine();

Console.WriteLine("Digite o nome da sua rua:");
ruaUsuario = Console.ReadLine();

Console.WriteLine("Digite o número da sua casa:");
numeroUsuario = Console.ReadLine();

Console.WriteLine("Digite o nome do seu bairro:");
bairroUsuario = Console.ReadLine();

Console.WriteLine("Digite o nome da sua cidade:");
cidadeUsuario = Console.ReadLine();

Console.WriteLine("Digite seu estado:");
ufUsuario = Console.ReadLine();

Console.WriteLine("Digite o nome do seu país:");
paisUsuario = Console.ReadLine();

Console.WriteLine(@$"Seus dados:
    [NOME]:         {nomeUsuario}
    [EMAIL]:        {eMailUsuario}
    [NASCIMENTO]:   {dataNascimento}
    [GÊNERO]:       {generoUsuario}
    [CEP]:          {cepUsuario}
    [RUA]:          {ruaUsuario}
    [NÚMERO]:       {numeroUsuario}
    [BAIRRO]:       {bairroUsuario}
    [CIDADE]:       {cidadeUsuario}
    [ESTADO]:       {ufUsuario}
    [PAÍS]:         {paisUsuario}
");
