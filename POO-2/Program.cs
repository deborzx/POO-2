using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //polimorfismo: voce so consegue acessar os dados do PAI; nao da pra acessar o turno do aluno;
            Usuario u = new Aluno("matutino", "Fabio", "f@hotmail.com", "senha");
            Usuario u2 = new Zelador("Carlos", "c@hotmail.com", "senha");

            //u.Exibir();
            Console.WriteLine("---------------------");

            //u2.Exibir();
            Console.WriteLine("---------------------");

            //para acessar o turno --> usar CAST (converteu VAR do tipo PAI para o tipo FILHO)
            //Console.WriteLine(((Aluno)u).turno);


            //polimorfismo sobrecarga
            //u.Logar("f@hotmail.com", 1234);
            //u.Logar(2323, 1234);



            //polimorfismo sobreposição
            u.Exibir();





            Console.WriteLine("\n-----------------------------------------------------------");







            //utilizando via construtor da class Usuario.cs
            Aluno a = new Aluno("Matutino", "Ben", "ben@hotmail.com", "dfdf23");

            /*------usando construtor em Program.cs
            a.nome = "Benjamin";
            a.email = "benjamin@hotmail.com";
            a.senha = "123";
            a.turno = "Matutino";
            */

            a.Logar();
            a.Exibir();



            /*------usando construtor em Program.cs
            Usuario u = new Usuario();
            u.nome = "Felipe";
            u.email = "felipe@hotmail.com";
            u.senha = "123";    
            //u.turno --> nao pode, porque o pai nao pode herdar do filho, e turno é de ALUNO
            */



            //utilizando via construtor da class Usuario.cs
            Zelador z = new Zelador("Ricard", "ricas@hotmail.com", "ksksks");

            /*------usando construtor em Program.cs
            z.email = "rodolfo@hotmai.com";
            z.nome = "Rodolfo";
            z.senha = "123";
            */

            z.Logar();
            z.Exibir();


            Console.ReadLine();

        }
    }
}
