using System;

namespace Seção_11_Tratamento_de_Exceções
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                int n1 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());


                int result = n1 / n3;
                Console.WriteLine(result);
            }
            // Exception -> é o mais genérico de todos, mas pode espeficar caso deseje
            // DivideByZeroException -> Tipo especifico da exception de divisão por zero
            // FormatException -> Erro no tipo de dado

            // Colocar o mais especifico possibilita uma melhor tratativa na hora de processar o erro
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is not allowed ! " + e.Message);
            }
            
            catch (FormatException e)
            {
                Console.WriteLine("Format not allowed");
            }

            // Bloco Finally - Roda o que tem de ser execultado independente do resultado ( pode ser fechar conaxão com o banco )

            finally
            {
                // Fechar leitura de arquivo tbm é importante
            }
            
        }
    }
}
