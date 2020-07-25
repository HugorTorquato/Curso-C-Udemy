using System;
using System.Globalization;

namespace DateTimea
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now; // Pega o horário atual do sistema
            Console.WriteLine(d1.Ticks);


            //Instanciar

            DateTime d2 = new DateTime(2018, 11, 25); // INSTANCIOU A ZERO HORAS
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); //instancia data completa
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500); // com milisegundos
            DateTime d5 = new DateTime(2018, 11, 25, 20, 45, 03, 500); // DatetimeKind -> Falar se é local ou global -> local-> padrão


            // Utilizar os bilders
            DateTime d10 = DateTime.Now;
            DateTime d11 = DateTime.Today; // Gera data de hoje as zero horas
            DateTime d12 = DateTime.UtcNow; // Horário de agora no GMT -> Horário universão

            // Usar o Parse

            DateTime d21 = DateTime.Parse("200-08-15"); //-> Converte data de string para datetime 
            DateTime d22 = DateTime.Parse("200-08-15 13:05:58"); //-> Converte data de string para datetime 
            DateTime d23 = DateTime.Parse("15/08/2000 13:05:58"); //-> Converte data de string para datetime 

            // Determinar o formato da data -> ParseExact
            DateTime d31 = DateTime.ParseExact("200-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); //-> Determina exatamente o formata para ser convertido
        }
    }
}
