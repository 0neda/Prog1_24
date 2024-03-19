using _240318_01.Models;

// Instância de objeto do tipo Customer
Customer c1 = new();

// Atribuindo valores aos atributos do objeto (c1)
c1.FirstName = "Alex";
c1.LastName = "Oneda";
c1.CustomerId = 1;
c1.BirthDate = new DateTime();
c1.EmailAddress = "a.oneda@unoesc.edu.br";

// Instância do objeto do tipo Address
Address address1 = new Address();

// Atribuindo valores aos atributos do objeto (address1)
address1.AddressId = 1;
address1.Street = "Nome da rua";
address1.Number = 666;
address1.District = "Distrito";
address1.City = "Cidade";
address1.FederalState = "Santa Catarina";
address1.Country = "Brazil";
address1.ZipCode = "89500-300";
// AddressType é do tipo Enum, portanto, espera receber um valor equivalente ao seu tipo.
address1.AddressType = AddressType.Commercial;

// Guardando um endereço à lista de endereços do consumidor
c1.Addresses.Add(address1);

Console.WriteLine($"Endereços");
foreach (var ad in c1.Addresses)
{
    Console.WriteLine($"------------------------------------------------------");
    Console.WriteLine($"Endereço ID: {ad.AddressId}");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Country}");
    Console.WriteLine($"CEP: {ad.ZipCode}");
}



Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine( $"E-mail: {c1.EmailAddress}");