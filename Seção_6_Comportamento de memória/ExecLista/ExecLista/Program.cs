using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExecLista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * -> Ler o número inteiro N de dados
             * -> Os dados ID, NOME SALÁRIO) de N funcionários sem a rpetição de IDs
             * 
             * -> Efetuar o aumento de X % no salário de um determinado funcionário
             *      -> Ler o ID e o valor X
             *      -> Se o ID não existir, mostrar uma msgem e abortar operação
             * 
             * -> Mostrar a listagem atualizada dos funcionários conforma exemplo
             * 
             * -> Encapsulamento para não permitir que o salário possa ser mudado livremente.
             * -> O salário só pode ser mudado com base em uma operação de aumento por porcentagem
             * 
             */


            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            // Declaração da Lista
            List<Employee> Emplo = new List<Employee>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.Write(" Employee ID : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write(" Employee Name : ");
                string nome = Console.ReadLine();
                Console.Write(" Employee Salary : ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Emplo.Add(new Employee(id, nome, salary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write(" ID of the emploee who will recieve the raise : ");
            int idVerify = int.Parse(Console.ReadLine());

            Employee EmpChanges = Emplo.Find(x => x.Id == idVerify); // Tem de criar um objeto somente para realizar a mudança

            if (EmpChanges != null)
            {
                Console.WriteLine();
                Console.Write(" Input the raise (%): ");
                double raise = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                EmpChanges.SalaryRaise(raise);

                Console.WriteLine(EmpChanges);
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine(" There is no Emploee with this ID, please try again ");
            }






            foreach (Employee obj in Emplo)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
