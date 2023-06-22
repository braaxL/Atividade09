using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista de vagas...
            List<string> vagas = new List<string>();

            Console.WriteLine("Bem-Vindo ao estacionamento SK");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Estacionar / 2. Retirar Veículo / 3. Listar Veículos");
            string placa = Console.ReadLine();

            while (true)
            {


                if (placa == "1")
                {
                    Console.WriteLine("Digite a Placa do Veículo");
                    vagas.Add(placa);
                }
                    
               if(placa == "2")
            {
                Console.WriteLine("Digite a Placa de Retirada");
                vagas.Remove(placa);
            }


               if (placa == "3")
                {
                    foreach (string placa in vagas)
                    {
                        Console.WriteLine(placa);
                    }
                }

            }
            Console.ReadKey();






            
                    
                








        }
    }
}
