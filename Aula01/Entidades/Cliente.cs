using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Entidades
{
    public class Cliente
    {
        private int codigo;
        private String email;
        private String nome;

        public Cliente()
        {

        }

        public Cliente(int codigo, string email, string nome)
        {
            this.codigo = codigo;
            this.email = email;
            this.nome = nome;
        }

        public int Codigo { get; set; }
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }


    }
}
