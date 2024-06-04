using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Controllers;
using _240401_01.Views;

namespace _240401_01.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;

        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");

            bool aux = true;
            do {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir consumidor");
                Console.WriteLine("2 - Pesquisar consumidor");
                Console.WriteLine("3 - Listar consumidores");
                Console.WriteLine("4 - Deletar consumidor");
                Console.WriteLine("5 - Exportar dados delimitados");
                Console.WriteLine("6 - Importar dados delimitados");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                            break;
                        case 1:
                            InsertCustomer();
                            break;
                        case 2:
                            SearchCustomer();
                            break;
                        case 3:
                            ListCustomers();
                            break;
                        case 4:
                            Console.WriteLine("Digite o ID do cliente para deletar:");
                            DeleteCustomer(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 5:
                            if(customerController.ExportToDelimited())
                                Console.WriteLine("Lista de consumidores exportada com sucesso.");
                            else
                                Console.WriteLine("Falha ao exportar lista de consumidores.");
                            break;
                        case 6:
                            ImportFromDelimited();
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }
                
            } while (aux);
        }


        private void ImportFromDelimited()
        {
            Console.WriteLine("Informe o caminho do arquivo:");
            string pathFile = Console.ReadLine();

            Console.WriteLine("Informe o caractere delimitador do arquivo:");
            string delimiter = Console.ReadLine();

            string response = customerController.ImportFromDelimited(pathFile, delimiter);

            Console.WriteLine(response);
        }
        private void InsertCustomer()
        {
            Console.WriteLine("***************");
            Console.WriteLine("NOVO CONSUMIDOR");
            Console.WriteLine("***************");
            Console.WriteLine("");

            Customer customer = new Customer();

            Console.Write("Nome: ");
            customer.Name = Console.ReadLine();

            Console.Write("Email: ");
            customer.EmailAddress = Console.ReadLine();

            int aux = 0;
            do {
                Console.WriteLine("Deseja informar o(s) endereço(s)?");
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");
                try {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if (aux == 1)
                    {
                        customer.Addressess.Add(addressView.Insert());
                    }
                    else if ( aux == 0 )
                    {
                        break;
                    }
                    else
                    {
                        aux = 1;
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                catch
                {
                    aux = 1;
                    Console.WriteLine("Opção inválida, tente novamente.");
                }                
            } while (aux != 0);

            try {
                customerController.Insert(customer);
                Console.WriteLine("Cliente inserido com sucesso!");
            } catch {
                Console.WriteLine("Ops! Ocorreu um erro!");
            }
            
        }

        private void SearchCustomer()
        {
            int aux = -1;
            do
            {
                Console.WriteLine("PESQUISAR CLIENTE");
                Console.WriteLine("*****************");
                Console.WriteLine("1 - Buscar por ID");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - Sair");
                
                string menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);

                switch(aux)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Digite o ID para pesquisar:");
                        ShowCustomerById(Convert.ToInt16(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome para pesquisar:");
                        ShowCustomersByName(Console.ReadLine());
                        break;
                    default:
                        aux = -1;
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            while (aux != 0); 
        }

        private void ShowCustomerById(int id)
        {
            Customer c = customerController.Get(id);

            if (c != null)
            {
                Console.WriteLine(c.ToString());
            }

            else
            {
                Console.WriteLine($"Consumidor de ID {id} não encontrado.");
            }
        }

        private void ShowCustomersByName(string name)
        {
            List<Customer> result = customerController.GetByName(name);
            if (result == null || result?.Count == 0)
            {
                Console.WriteLine($"Nenhum cliente com o nome de {name} foi encontrado.");
                return;
            }
            
            foreach (Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        private void ListCustomers()
        {
            List<Customer> result = customerController.Get();
            if (result == null || result?.Count == 0)
            {
                Console.WriteLine($"Nenhum cliente foi encontrado.");
                return;
            }
            
            foreach (Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        private void DeleteCustomer(int id)
        {
            customerController.Delete(id);
            //Console.WriteLine($"Cliente de ID {id} deletado com sucesso.");
        }

    }
}