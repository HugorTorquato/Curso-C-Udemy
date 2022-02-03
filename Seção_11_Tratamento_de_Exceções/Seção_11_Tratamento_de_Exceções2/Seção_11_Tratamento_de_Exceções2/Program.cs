using System;
using Seção_11_Tratamento_de_Exceções2.Entities;
using Seção_11_Tratamento_de_Exceções2.Entities.Exceptions;

namespace Seção_11_Tratamento_de_Exceções2
{
    /*
     * Programa para ler dados de reserva de hotel
         * Número do quarto
         * Data de entrada
         * Data de saída
     * Mostrar Dados
        * Dados da reserva
        * Duração em dias
     * Funcionalidades
        * Ler novas datas de entrada 
        * Ler novas datas de saída
        * Atualizar reserva
        * Mostrar novamente com os dados atualizados
     * Condições
        * Não deve aceitar dados inválidos
        * Alteração só pode ocorrer para datas futuras
        * Data de saída deve ser maior que a de entrada
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Room Number :");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Checkin Date :");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Checkout Date :");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                // Instanciando
                Reservation res = new Reservation(number, checkin, checkout);

                Console.WriteLine(res);

                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation");

                Console.WriteLine("Enter Room Number :");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Checkin Date :");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Checkout Date :");
                checkout = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(res);
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid Format ! " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro : " + e.Message);
            }
        }
    }
}
