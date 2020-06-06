using Aula01.Entidades;
using Aula01.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();


            Console.WriteLine("Cadastro de Cliente");           

            Console.WriteLine("Insira seu codigo do cliente: ");
            cliente.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu email: ");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("Insira seu nome: ");
            cliente.Nome = Console.ReadLine();

            ClienteServices clienteServices = new ClienteServices();
            clienteServices.GravarArquivo(cliente);

            Console.WriteLine("Dados gravados com sucesso");

            //Console.WriteLine("Codigo:{0} Email:{1} Nome:{2} ", CodigoCliente, EmailCliente, NomeCliente);
            Console.ReadKey();




        }
    }
}
