using _240401_01.Models;

Console.WriteLine("Hello, World!");

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
};