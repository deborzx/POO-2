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
