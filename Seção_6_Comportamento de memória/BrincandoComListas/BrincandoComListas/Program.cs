using System;
using System.Collections.Generic;

namespace BrincandoComListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação mais instanciação
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Joçao" };
            list.Add("Maria");

            list2.Add("Hugo");

            foreach (string q in list2) { Console.WriteLine(q); }
            list2.Insert(2, "Tayna");
            Console.WriteLine("-----------------------");
            foreach (string q in list2) { Console.WriteLine(q); }
            Console.WriteLine("-----------------------");
            Console.WriteLine(list2.Count);
            Console.WriteLine("-----------------------");
            Console.WriteLine(list2.Find(x => x[0] == 'T'));
            Console.WriteLine("-----------------------");
            Console.WriteLine(list2.FindLast(x => x[0] == 'o'));
            Console.WriteLine("-----------------------");
            Console.WriteLine(list2.FindLastIndex(x => x[0] == 'o'));
            Console.WriteLine("-----------------------");
            foreach (string a in list2.FindAll(x => x.Length >= 2)) { Console.WriteLine(a); }
            Console.WriteLine("-----------------------");
            list2.Remove("Hugo");
            foreach (string a in list2.FindAll(x => x.Length >= 2)) { Console.WriteLine(a); }
            Console.WriteLine("-----------------------");
            list2.RemoveAll(X=> X.Length >= 2);
            foreach (string a in list2.FindAll(x => x.Length >= 2)) { Console.WriteLine(a); }
        }

    }
}

