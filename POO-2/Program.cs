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

            Aluno a = new Aluno();
            a.nome = "Benjamin";
            a.email = "benjamin@hotmail.com";
            a.senha = "123";
            a.turno = "Matutino";
            a.Logar();
            a.Exibir();




            Usuario u = new Usuario();
            u.nome = "Felipe";
            u.email = "felipe@hotmail.com";
            u.senha = "123";    
            //u.turno --> nao pode, porque o pai nao pode herdar do filho, e turno é de ALUNO


            Zelador z = new Zelador();
            z.email = "rodolfo@hotmai.com";
            z.nome = "Rodolfo";
            z.senha = "123";
            z.Logar();
            z.Exibir();


            Console.ReadLine();

        }
    }
}
