using Aula01.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Services
{
    public class ClienteServices 
    {
        public void GravarArquivo(Cliente cliente)
        {
            using (StreamWriter writer = new StreamWriter("c:\\temp\\clientes.txt", true))
            {
                writer.WriteLine("Codigo: " + cliente.Codigo);
                writer.WriteLine("Email: " + cliente.Email);
                writer.WriteLine("Nome: " + cliente.Nome);

                writer.WriteLine("***************");
            }
        }

    }
}
