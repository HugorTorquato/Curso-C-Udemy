using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração
            /*
            List<string> list; // Declaração de lista
            List<string> list2 = new List<string>(); // Declaração de lista + instanciação de lista vazia, somente depois coloca elementos
            List<string> list3 = new List<string> { "Maria", "Alex" }; // Declaração de lista + instanciação de lista alocadas
            */

            // Criar uma Lista

            List<string> list = new List<string>();

            //Adicionar elementos
            list.Add("Maria");
            list.Add("Alex");
            list.Add("bOD");
            list.Add("Anna");

            // Insert
            list.Insert(2, "Marco");

            //Count -> Tamanho da lista 

            foreach (string ibj in list)
            {
                Console.WriteLine(ibj);
            }

            Console.WriteLine();
            Console.WriteLine(list.Count);

            // Find / FindLast

            string s1 = list.Find(x => x[0] == 'A'); // Argumento predicado -> Eu quero x talque x na posição 0 seja igual a 'A' 
            Console.WriteLine();
            Console.WriteLine(" pRIMEIRO QUE COMEÇA COM 'A' é : " + s1);

            string s2 = list.FindLast(X => X[0] == 'A');
            Console.WriteLine();
            Console.WriteLine("ULTIMO QUE COMEÇA COM 'A' é : " + s2);
            Console.WriteLine();

            // Find / FindLast ( index) 

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(" Indice primeiro : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(" Indice ULTIMO : " + pos2);


            // fILTRAR LISTA

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();
            Console.WriteLine(" Resultado");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remover
            Console.WriteLine();
            Console.WriteLine(" Remove ");

            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine();
            Console.WriteLine(" Remove ");

            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            // RemoveAt
            list.RemoveAt(0);
            Console.WriteLine();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            // RemoveRange
            list.RemoveRange(0, 1);
            Console.WriteLine();
            Console.WriteLine(" Remove range");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }

}
