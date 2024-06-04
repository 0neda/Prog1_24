using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Repository;
using _240401_01.Utils;

namespace _240401_01.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }

        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);            
        }

        public void Delete (int id)
        {
            customerRepository.Delete(id);
        }

        public Customer Get(int id)
        {
            return customerRepository.Retrieve(id);
        }

        public List<Customer> Get()
        {
            return customerRepository.Retrieve();
        }

        public List<Customer> GetByName(string name)
        {
            return customerRepository.RetrieveByName(name);
        }

        public bool ExportToDelimited()
        {
            List<Customer> list = customerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach(var c in list)
            {
                fileContent += $"{c.PrintToExportDelimited()}\n";
            }
            
            string fileName = $"Customers_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";
            return ExportToFile.SaveToDelimitedTxt(fileName, fileContent);
        }

        public string ImportFromDelimited(string filePath, string delimiter)
        {
            bool result = true;
            string msgReturn = string.Empty;
            int lineCountSuccess = 0;
            int lineCountError = 0;
            int lineCountTotal = 0;

            try
            {
                if (!File.Exists(filePath))
                    return "[ERRO] Arquivo de importação não existente.";
                
                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line = string.Empty;
                    while((line = sr.ReadLine()) != null)
                    {
                        lineCountTotal++;
                        if (!customerRepository.ImportFromTxt(line, delimiter))
                        {
                            result = false;
                            lineCountError++;
                        }
                        else
                            lineCountSuccess++;
                    }
                }
            }
            catch(System.Exception ex)
            {
                return $"[ERRO] {ex.Message}";
            }

            if(result)
                msgReturn = "Dados importados com sucesso.";
            else
                msgReturn = "Dados parcialmente importados.";

            msgReturn += $"\nTotal de linhas: {lineCountTotal}\nLinhas com sucesso: {lineCountSuccess}\nLinhas com erro: {lineCountError}";

            return msgReturn;
        }
    }
}