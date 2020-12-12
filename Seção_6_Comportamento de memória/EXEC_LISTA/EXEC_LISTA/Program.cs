using System;
using System.Collections.Generic;
using System.Globalization;

namespace EXEC_LISTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qUANTOS FUNCIONÁRIOS DESEJA CADASTRAR?");
            int N = int.Parse(Console.ReadLine());

            List<Func> Funcionarios = new List<Func>();

            for (int i=0; i < N; i++)
            {
                Console.WriteLine("Qual o ID?");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o Nome?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o Salario?");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionarios.Add(new Func(id, nome, sal));

            }

            Console.WriteLine(" Qual o ID para o aumento?");
            int id_add = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a % do aumento?");
            int x = int.Parse(Console.ReadLine());

            if (Funcionarios.FindIndex(X => X.ID == id_add) != -1)
            {
                Funcionarios.Find(X => X.ID == id_add).AddSalary(x);
            }
            else { Console.WriteLine("ID NÃO EXISTE"); }

            foreach (Func a in Funcionarios) { Console.WriteLine(a); }

        }
    }
}
