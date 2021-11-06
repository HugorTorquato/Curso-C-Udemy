using System;
using System.IO;
using System.Globalization;
using FileExec.Entities;

namespace FileExec
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"C:\Users\hugo1\Desktop\Treinamentos\C# .net\Udemy C#\Seção_13_Trabalhando com arquivos\source.csv";
            string DestinationPath = @"C:\Users\hugo1\Desktop\Treinamentos\C# .net\Udemy C#\Seção_13_Trabalhando com arquivos\Out\Summary.csv";


            try
            {
                // VALIDAÇÃO E CRIAÇÃO DOS ARQUIVOS
                FileInfo source = new FileInfo(SourcePath);
                DirectoryInfo sourceDirectory = new DirectoryInfo(source.DirectoryName);

                string DestinationDirectory = Path.Combine(sourceDirectory.ToString(), "Out");
                    
                if (Directory.Exists(DestinationDirectory))
                {
                    Directory.Delete(DestinationDirectory, true);
                }
                DirectoryInfo Destination = Directory.CreateDirectory(DestinationDirectory);
                // Leitura e instanciação dos produtos

                string[] sourceTxt = File.ReadAllLines(SourcePath);

                using (StreamWriter sw = File.AppendText(DestinationPath))
                {


                    foreach (string a in sourceTxt)
                    {
                        Console.WriteLine(a);
                        string[] line = a.Split(',');


                        Product pro = new Product(line[0], double.Parse(line[1], CultureInfo.InvariantCulture), int.Parse(line[2]));

                        sw.WriteLine(pro.ProductName + "," + pro.ReturnTotal().ToString("F2", CultureInfo.InvariantCulture));




                    }
                }



                // Output




            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred : " + e.Message);
            }
        }
    }
}
