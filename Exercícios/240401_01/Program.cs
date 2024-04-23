using _240401_01.Models;
using _240401_01.Views;

bool aux = true;

do {
    Console.WriteLine("************");
    Console.WriteLine("MY ORDER APP");
    Console.WriteLine("************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - Sair");
    
    int menu = 0;


    try {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu)
        {
            case 1:
                CustomerView customerView = new CustomerView();
                break;
            case 2:
                ProductView productView = new ProductView();
                break;
            case 3:
                break;
            case 0:
                aux = false;
                Console.WriteLine("See you soon!");
                break;
            default:
                Console.WriteLine("Opção inválida");
                aux = true;
                break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inválida");
        aux = true;
        menu = -1;
    }

} while (aux);

/*Console.WriteLine("Hello, World!");

Customer c1 = new Customer(); // Construtor Padrão (Default Constructor)
c1.CustomerId = 1;
c1.Name = "Peixe Pacu";
c1.EmailAddress = "pacu@pantanal.com.br";

Customer c2 = new Customer(2); // Construtor de Instanciação (Instantiation Constructor)
c1.Name = "Piranha";
c1.EmailAddress = "piranha@pantanal.com.br";

Customer c3 = new Customer{ // Construtor por atribuição (Attribution Constructor)
    CustomerId = 3,
    Name = "Seu Nelson",
    EmailAddress = "nelsinho@bocamole.com.br"
};*/
