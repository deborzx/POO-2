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
        //protected string teste;

        //construtor gerado
        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        //logar void - pois nao recebe nada
        public void Logar()
        {
            //Console.WriteLine(teste);
            Console.WriteLine("\nLogando..");
        }



        //polimorfismo de sobrecarga
        //logar string - pois recebe string
        public void Logar(string email, int senha)
        {
            //Console.WriteLine(teste);
            Console.WriteLine("\nLogando com email+senha");
        }


        public void Logar(int pin, int senha)
        {
            //Console.WriteLine(teste);
            Console.WriteLine("\nLogando com pin+senha");
        }




        //polimorfismo de sobreposição - utilizando a palavra 'virtual'

        public virtual void Exibir()
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
           //Console.WriteLine(teste);
        }


        //construtor da class pai
        public Aluno(string turno, string nome, string email, string senha): base(nome, email, senha)
        {
            this.turno = turno;
        }


        //metodo exibir com polimorfismo
        public override void Exibir()
        {
            Console.WriteLine("Dados do aluno: ");
            base.Exibir();
            Console.WriteLine($"seu turno é: {turno}");
        }

    }


    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();

        //construtor da class pai
        public Zelador(string nome, string email, string senha): base(nome, email, senha)
        {
            
        }
    }


}
