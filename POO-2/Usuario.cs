using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    internal class Usuario
    {

        public string nome;
        public string email;
        public string senha;
        protected string teste;

        public void Logar()
        {
            Console.WriteLine(teste);
            Console.WriteLine("Logando..\n");
        }

        public void Exibir()
        {
            Console.WriteLine($"email: {email}");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"senha: {senha}");

        }
    }

    //herança: aluno herda de usuario
    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        public void Testando()
        {
            Console.WriteLine(teste);
        }

    }


    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();
         
    }


}
