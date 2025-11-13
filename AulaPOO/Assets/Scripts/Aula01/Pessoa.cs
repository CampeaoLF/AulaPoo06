using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Pessoa  
    {
        private string nome;  //caracteristicas//
        private string email;


        public void receberUmNome(string nome)
        {
            this.nome = nome;
        }

        public string falarMeuNome()
        {
            return "Meu nome é " + nome;
        }
        public string perguntarONome(Pessoa p)
        {
            string mensagem = "Eae, qual seu nome truta? ";
            mensagem += p.falarMeuNome();
            return mensagem;
        }
    }
}
